using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gma.UserActivityMonitor;

namespace Schillinger_Quest4_ErrorInputDatabase
{
    public partial class Recording : Form
    {
        #region fields
        public static Recording recording;
        BugForm bugForm;

        XML xmlFile = new XML();
        XML session;

        Timer timer;
        int count = 0;

        XML lastEvent = null;

        #endregion

        #region Properties
        XML Event
        {
            get
            {
                if (lastEvent != null)
                {
                    return lastEvent;
                }

                lastEvent = getNewEventXML();
                return lastEvent;
            }
        }

        XML MouseEvent
        {
            get
            {
                return Event.AddChild("Mouse");
            }
        }

        XML KeyboardEvent
        {
            get
            {
                return Event.AddChild("Keyboard");
            }
        }
        #endregion

        enum Status
        {
            Not_Recording,
            Recording
        }

        Status status = Status.Not_Recording;

        public Recording()
        {
            InitializeComponent();
            Singleton();
            stopRecordingBtn.Enabled = false;
            stopRecordingBtn.Visible = false;
        }

        private void Singleton()
        {
            if(recording == null)
            {
                recording = this;
            } else
            {
                this.Close();
            }
        }

        private void stopRecordingBtn_Click(object sender, EventArgs e)
        {
            status = Status.Not_Recording;
            ToggleButtons();
        }

        private void recordBtn_Click(object sender, EventArgs e)
        {
            status = Status.Recording;
            ToggleButtons();
        }

        private void ToggleButtons()
        {
            ToggleButton(recordBtn);
            ToggleButton(stopRecordingBtn);
        }

        private void ToggleButton(Button btn)
        {
            btn.Enabled = !btn.Enabled;
            btn.Visible = !btn.Visible;
        }


        #region Helper Methods
        XML getNewEventXML()
        {
            timer.Stop();
            XML eventXML = session.AddChild("Event");
            eventXML.AddAttribute("Time", count.ToString());

            count = 0;
            timer.Start();

            return eventXML;
        }

        private void Count(object sender, EventArgs e)
        {
            count++;
            lastEvent = null;
        }
        #endregion

        #region Events
        #region Form Events
        private void Recording_Load(object sender, EventArgs e)
        {
        }

        private void Recording_FormClosing(object sender, FormClosingEventArgs e)
        {
            //xmlFile.ExportXML(bugName + ".XML");
        }
        #endregion

        #region Mouse Events
        private void MouseMove(object sender, MouseEventArgs e)
        {
            XML mouseEvent = MouseEvent;
            mouseEvent.AddAttribute("Position", e.Location.ToString());
        }

        //Mouse click removed because we have the up and down functions to track it
        //private void MouseClick(object sender, MouseEventArgs e)
        //{
        //    XML mouseEvent = MouseEvent;
        //    mouseEvent.AddAttribute("Click", e.Button.ToString());
        //}
        private void MouseUp(object sender, MouseEventArgs e)
        {
            XML mouseEvent = MouseEvent;
            mouseEvent.AddAttribute(e.Button.ToString(), "Up");
        }

        private void MouseDown(object sender, MouseEventArgs e)
        {
            XML mouseEvent = MouseEvent;
            mouseEvent.AddAttribute(e.Button.ToString(), "Down");
        }

        private void MouseWheelMove(object sender, MouseEventArgs e)
        {
            XML mouseEvent = MouseEvent;
            mouseEvent.AddAttribute("Scroll", e.Delta.ToString());
        }
        #endregion

        #region KeyBoard Event
        private void KeyUp(object sender, KeyEventArgs e)
        {
            XML keyBoardEvent = KeyboardEvent;
            keyBoardEvent.AddAttribute(e.KeyCode.ToString(), "Up");
        }

        private void KeyDown(object sender, KeyEventArgs e)
        {
            XML keyBoardEvent = KeyboardEvent;
            keyBoardEvent.AddAttribute(e.KeyCode.ToString(), "Down");
        }
        #endregion

        #region Event Helper Methods
        private void AddEvents()
        {
            HookManager.MouseUp += MouseUp;
            HookManager.MouseDown += MouseDown;
            HookManager.MouseMove += MouseMove;
            HookManager.KeyUp += KeyUp;
            HookManager.KeyDown += KeyDown;
            HookManager.MouseWheel += MouseWheelMove;
        }

        private void RemoveEvents()
        {
            HookManager.MouseUp -= MouseUp;
            HookManager.MouseDown -= MouseDown;
            HookManager.MouseMove -= MouseMove;
            HookManager.KeyUp -= KeyUp;
            HookManager.KeyDown -= KeyDown;
            HookManager.MouseWheel -= MouseWheelMove;
        }
        #endregion

        #endregion

        private void reportBtn_Click(object sender, EventArgs e)
        {
            bugForm = new BugForm();
            bugForm.Show();
            this.Hide();
        }
    }
}
