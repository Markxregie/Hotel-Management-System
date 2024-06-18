using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_CASE_STUDY.Forms
{
    public partial class DashboardForm : Form
    {
        private IconButton currentBtn;
        private Panel rightBorderBtn;
        private Form currentChildForm;

        public DashboardForm()
        {
            InitializeComponent();
            rightBorderBtn = new Panel();
            rightBorderBtn.Size = new Size(2, 5);
            rightBorderBtn.BackColor = Color.White;
            panelMenu.Controls.Add(rightBorderBtn);

            // Form Layout
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

            // Initialize buttons
            InitializeButtons();
        }

        private void InitializeButtons()
        {
            foreach (Control ctrl in panelMenu.Controls)
            {
                if (ctrl is IconButton)
                {
                    ctrl.Click += Button_Click;
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

        }

        // Methods
        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                // Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(16, 44, 87);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.White;

                // Bottom border (underline)
                rightBorderBtn.Size = new Size(5, currentBtn.Height - 10);
                rightBorderBtn.Location = new Point(currentBtn.Location.X + currentBtn.Width - 6, currentBtn.Location.Y + 5);
                rightBorderBtn.Visible = true;
                rightBorderBtn.BringToFront();
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(0, 7, 45);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.White;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                // Close the current child form if it exists.
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Booking_Button_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            //OpenChildForm(new BookingForm());
        }

        private void Room_Button_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            //OpenChildForm(new RoomForm());
        }

        private void Guests_Button_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            //OpenChildForm(new GuestsForm());
        }

        private void Invoices_Button_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            //OpenChildForm(new InvoiceListForm());
        }

        private void Dashboard_Button_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            // OpenChildForm(new DashboardForm());
        }

        private void Report_Button_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            // OpenChildForm(new ReportForm());
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximized_WindowButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void Minimized_Button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // To drag the window
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void windowDashboard_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
