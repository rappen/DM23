using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using Rappen.XRM.Helpers.Extensions;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using XrmToolBox.Extensibility;

namespace DM23
{
    public partial class MyPluginControl : PluginControlBase
    {
        private Settings mySettings;

        public MyPluginControl()
        {
            InitializeComponent();
        }

        private void MyPluginControl_Load(object sender, EventArgs e)
        {
            ShowInfoNotification("This is a notification that can lead to XrmToolBox repository", new Uri("https://github.com/MscrmTools/XrmToolBox"));

            // Loads or creates the settings for the plugin
            if (!SettingsManager.Instance.TryLoad(GetType(), out mySettings))
            {
                mySettings = new Settings();

                LogWarning("Settings not found => a new settings file has been created!");
            }
            else
            {
                LogInfo("Settings found and loaded");
            }
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            CloseTool();
        }

        private void tsbSample_Click(object sender, EventArgs e)
        {
            // The ExecuteMethod method handles connecting to an
            // organization if XrmToolBox is not yet connected
            ExecuteMethod(GetAccounts);
        }

        private void GetAccounts()
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Getting accounts",
                Work = (worker, args) =>
                {
                    args.Result = Service.RetrieveMultiple(new QueryExpression("account")
                    {
                        TopCount = 50
                    });
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    var result = args.Result as EntityCollection;
                    if (result != null)
                    {
                        MessageBox.Show($"Found {result.Entities.Count} accounts");
                    }
                }
            });
        }

        /// <summary>
        /// This event occurs when the plugin is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyPluginControl_OnCloseTool(object sender, EventArgs e)
        {
            // Before leaving, save the settings
            SettingsManager.Instance.Save(GetType(), mySettings);
        }

        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox
        /// </summary>
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);

            if (mySettings != null && detail != null)
            {
                mySettings.LastUsedOrganizationWebappUrl = detail.WebApplicationUrl;
                LogInfo("Connection has changed to: {0}", detail.WebApplicationUrl);
            }
        }

        private void MyPluginControl_ConnectionUpdated(object sender, ConnectionUpdatedEventArgs e)
        {
            xrmView.Service = Service;
            xrmData.Service = Service;
            xrmRecordHost1.Service = Service;
            GetTables();
        }

        private void GetTables()
        {
            Enabled = false;
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Loading Tables...",
                Work = (worker, args) =>
                {
                    args.Result = Service.LoadEntities().EntityMetadata;
                },
                PostWorkCallBack = (args) =>
                {
                    Enabled = true;
                    if (args.Error != null)
                    {
                        ShowErrorDialog(args.Error);
                    }
                    else if (args.Result is EntityMetadataCollection entities)
                    {
                        xrmEntity.DataSource = entities
                            .Where(e => chkManaged.Checked || e.IsManaged == false);
                    }
                }
            });
        }

        private void chkManaged_CheckedChanged(object sender, EventArgs e)
        {
            GetTables();
        }

        private void xrmEntity_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetViews();
        }

        private void GetViews()
        {
            var entity = xrmEntity.SelectedEntity;
            xrmPrimaryName.Column = entity?.PrimaryNameAttribute;
            if (entity == null)
            {
                xrmView.DataSource = null;
                return;
            }
            var query = new QueryExpression("savedquery")
            {
                ColumnSet = new ColumnSet("name", "fetchxml", "layoutxml"),
                Criteria =
                {
                    Conditions =
                    {
                        new ConditionExpression("statecode", ConditionOperator.Equal, 0),
                        new ConditionExpression("fetchxml", ConditionOperator.NotNull),
                        new ConditionExpression("returnedtypecode", ConditionOperator.Equal, entity.LogicalName)
                    }
                }
            };
            Enabled = false;
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Loading Views...",
                Work = (worker, args) =>
                {
                    args.Result = Service.RetrieveMultipleAll(query);
                },
                PostWorkCallBack = (args) =>
                {
                    Enabled = true;
                    if (args.Error != null)
                    {
                        ShowErrorDialog(args.Error);
                    }
                    else if (args.Result is EntityCollection views)
                    {
                        xrmView.DataSource = views;
                    }
                }
            });
        }

        private void xrmView_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            var fetch = xrmView.SelectedRecord?.GetAttributeValue<string>("fetchxml");
            var layout = xrmView.SelectedRecord?.GetAttributeValue<string>("layoutxml");
            if (string.IsNullOrWhiteSpace(fetch))
            {
                xrmData.DataSource = null;
                return;
            }
            Enabled = false;
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Loading Data...",
                Work = (worker, args) =>
                {
                    //args.Result = Service.RetrieveMultipleAll(new FetchExpression(fetch));
                    xrmData.SetDataSource(fetch, layout);
                },
                PostWorkCallBack = (args) =>
                {
                    Enabled = true;
                    if (args.Error != null)
                    {
                        ShowErrorDialog(args.Error);
                    }
                    else if (args.Result is EntityCollection data)
                    {
                        xrmData.DataSource = data;
                    }
                }
            });
        }

        private void xrmData_RecordClick(object sender, Rappen.XTB.Helpers.Controls.XRMRecordEventArgs e)
        {
            xrmRecordHost1.Record = e.Entity;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            Enabled = false;
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Saving!",
                Work = (worker, args) =>
                {
                    args.Result = xrmRecordHost1.SaveChanges();
                },
                PostWorkCallBack = (args) =>
                {
                    Enabled = true;
                    if (args.Error != null)
                    {
                        ShowErrorDialog(args.Error);
                    }
                    else if (args.Result is bool result && result)
                    {
                        GetData();
                    }
                }
            });
        }
    }
}