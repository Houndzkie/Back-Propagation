namespace Back_Propagation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.titleLabel = new System.Windows.Forms.Label();
            this.hiddenNodesLabel = new System.Windows.Forms.Label();
            this.hiddenNodesTextBox = new System.Windows.Forms.TextBox();
            this.rowsLabel = new System.Windows.Forms.Label();
            this.rowsTextBox = new System.Windows.Forms.TextBox();
            this.epochsLabel = new System.Windows.Forms.Label();
            this.epochsTextBox = new System.Windows.Forms.TextBox();
            this.learningRateLabel = new System.Windows.Forms.Label();
            this.learningRateTextBox = new System.Windows.Forms.TextBox();
            this.momentumLabel = new System.Windows.Forms.Label();
            this.momentumTextBox = new System.Windows.Forms.TextBox();
            this.seedLabel = new System.Windows.Forms.Label();
            this.seedTextBox = new System.Windows.Forms.TextBox();
            this.runButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(18, 15);
            this.titleLabel.Text = "Back-Propagation Neural Network";
            this.hiddenNodesLabel.AutoSize = true;
            this.hiddenNodesLabel.Location = new System.Drawing.Point(20, 58);
            this.hiddenNodesLabel.Text = "Hidden nodes";
            this.hiddenNodesTextBox.Location = new System.Drawing.Point(110, 55);
            this.hiddenNodesTextBox.Size = new System.Drawing.Size(55, 23);
            this.hiddenNodesTextBox.Text = "5";
            this.rowsLabel.AutoSize = true;
            this.rowsLabel.Location = new System.Drawing.Point(185, 58);
            this.rowsLabel.Text = "Rows";
            this.rowsTextBox.Location = new System.Drawing.Point(225, 55);
            this.rowsTextBox.Size = new System.Drawing.Size(65, 23);
            this.rowsTextBox.Text = "1000";
            this.epochsLabel.AutoSize = true;
            this.epochsLabel.Location = new System.Drawing.Point(310, 58);
            this.epochsLabel.Text = "Epochs";
            this.epochsTextBox.Location = new System.Drawing.Point(360, 55);
            this.epochsTextBox.Size = new System.Drawing.Size(65, 23);
            this.epochsTextBox.Text = "1000";
            this.learningRateLabel.AutoSize = true;
            this.learningRateLabel.Location = new System.Drawing.Point(445, 58);
            this.learningRateLabel.Text = "Learning rate";
            this.learningRateTextBox.Location = new System.Drawing.Point(530, 55);
            this.learningRateTextBox.Size = new System.Drawing.Size(65, 23);
            this.learningRateTextBox.Text = "0.05";
            this.momentumLabel.AutoSize = true;
            this.momentumLabel.Location = new System.Drawing.Point(20, 92);
            this.momentumLabel.Text = "Momentum";
            this.momentumTextBox.Location = new System.Drawing.Point(110, 89);
            this.momentumTextBox.Size = new System.Drawing.Size(55, 23);
            this.momentumTextBox.Text = "0.01";
            this.seedLabel.AutoSize = true;
            this.seedLabel.Location = new System.Drawing.Point(185, 92);
            this.seedLabel.Text = "Seed";
            this.seedTextBox.Location = new System.Drawing.Point(225, 89);
            this.seedTextBox.Size = new System.Drawing.Size(65, 23);
            this.seedTextBox.Text = "1";
            this.runButton.Location = new System.Drawing.Point(445, 87);
            this.runButton.Size = new System.Drawing.Size(100, 28);
            this.runButton.Text = "Run training";
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            this.clearButton.Location = new System.Drawing.Point(550, 87);
            this.clearButton.Size = new System.Drawing.Size(75, 28);
            this.clearButton.Text = "Clear";
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            this.outputTextBox.Font = new System.Drawing.Font("Consolas", 9F);
            this.outputTextBox.Location = new System.Drawing.Point(20, 130);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTextBox.Size = new System.Drawing.Size(605, 360);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 510);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.hiddenNodesLabel);
            this.Controls.Add(this.hiddenNodesTextBox);
            this.Controls.Add(this.rowsLabel);
            this.Controls.Add(this.rowsTextBox);
            this.Controls.Add(this.epochsLabel);
            this.Controls.Add(this.epochsTextBox);
            this.Controls.Add(this.learningRateLabel);
            this.Controls.Add(this.learningRateTextBox);
            this.Controls.Add(this.momentumLabel);
            this.Controls.Add(this.momentumTextBox);
            this.Controls.Add(this.seedLabel);
            this.Controls.Add(this.seedTextBox);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.outputTextBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Back-Propagation Demo";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label hiddenNodesLabel;
        private System.Windows.Forms.TextBox hiddenNodesTextBox;
        private System.Windows.Forms.Label rowsLabel;
        private System.Windows.Forms.TextBox rowsTextBox;
        private System.Windows.Forms.Label epochsLabel;
        private System.Windows.Forms.TextBox epochsTextBox;
        private System.Windows.Forms.Label learningRateLabel;
        private System.Windows.Forms.TextBox learningRateTextBox;
        private System.Windows.Forms.Label momentumLabel;
        private System.Windows.Forms.TextBox momentumTextBox;
        private System.Windows.Forms.Label seedLabel;
        private System.Windows.Forms.TextBox seedTextBox;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox outputTextBox;

        #endregion
    }
}

