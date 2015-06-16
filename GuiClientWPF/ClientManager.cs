using CommonInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Threading.Tasks;
namespace GuiClientWPF
{
    class ClientManager
    {
        private ILogic logic;

        internal Task Disconnect()
        {
            var disconnectionTask = new Task(() => {
             logic.DisconnectFromServer();
            });

            disconnectionTask.Start();
            return disconnectionTask;
        }

        internal Task ConnectAction()
        {
            var connectionTask = new Task(() =>
            {
                logic.ConnenctToServer();
            });

            connectionTask.Start();
            return connectionTask;
        }

        internal Task SaveComponent(Canvas canvas)
        {
            var saveTask = new Task(() =>
            {
                logic.SaveComponent(this.GenerateComponent(canvas));
            });

            saveTask.Start();
            return saveTask;
       }

        private IComponent GenerateComponent(Canvas canvas)
        {
            return default(IComponent);
        }
    }
}
