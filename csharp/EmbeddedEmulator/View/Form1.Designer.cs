﻿/*
Embedded Debugger PC Application which can be used to debug embedded systems at a high level.
Copyright (C) 2019 DEMCON advanced mechatronics B.V.

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/
namespace EmbeddedEmulator.View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openServerButton = new System.Windows.Forms.Button();
            this.closeServerButton = new System.Windows.Forms.Button();
            this.sendVersionButton = new System.Windows.Forms.Button();
            this.sendInfoButton = new System.Windows.Forms.Button();
            this.sendValueButton = new System.Windows.Forms.Button();
            this.connectionChooserComboBox = new System.Windows.Forms.ComboBox();
            this.settingsButton = new System.Windows.Forms.Button();
            this.stopSendingButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sendingGroupBox = new System.Windows.Forms.GroupBox();
            this.SaveConfigFileButton = new System.Windows.Forms.Button();
            this.MultipleNodesConfigGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.SimulateMultipleNodes = new System.Windows.Forms.CheckBox();
            this.ResponsesGroupBox = new System.Windows.Forms.GroupBox();
            this.SendConfigButton = new System.Windows.Forms.Button();
            this.AutoRespondCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.StringTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IntTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BoolButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.embeddedTerminal1 = new EmbeddedDebugger.View.CustomComponents.EmbeddedTerminal(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.sendingGroupBox.SuspendLayout();
            this.MultipleNodesConfigGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.ResponsesGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // openServerButton
            // 
            this.openServerButton.Location = new System.Drawing.Point(6, 19);
            this.openServerButton.Name = "openServerButton";
            this.openServerButton.Size = new System.Drawing.Size(81, 23);
            this.openServerButton.TabIndex = 0;
            this.openServerButton.Text = "Open server";
            this.openServerButton.UseVisualStyleBackColor = true;
            this.openServerButton.Click += new System.EventHandler(this.OpenServerButton_Click);
            // 
            // closeServerButton
            // 
            this.closeServerButton.Location = new System.Drawing.Point(93, 19);
            this.closeServerButton.Name = "closeServerButton";
            this.closeServerButton.Size = new System.Drawing.Size(74, 23);
            this.closeServerButton.TabIndex = 3;
            this.closeServerButton.Text = "Close server";
            this.closeServerButton.UseVisualStyleBackColor = true;
            this.closeServerButton.Click += new System.EventHandler(this.CloseServerButton_Click);
            // 
            // sendVersionButton
            // 
            this.sendVersionButton.Location = new System.Drawing.Point(6, 17);
            this.sendVersionButton.Name = "sendVersionButton";
            this.sendVersionButton.Size = new System.Drawing.Size(103, 23);
            this.sendVersionButton.TabIndex = 5;
            this.sendVersionButton.Text = "Send Version";
            this.sendVersionButton.UseVisualStyleBackColor = true;
            this.sendVersionButton.Click += new System.EventHandler(this.SendVersionButton_Click);
            // 
            // sendInfoButton
            // 
            this.sendInfoButton.Location = new System.Drawing.Point(6, 46);
            this.sendInfoButton.Name = "sendInfoButton";
            this.sendInfoButton.Size = new System.Drawing.Size(103, 23);
            this.sendInfoButton.TabIndex = 6;
            this.sendInfoButton.Text = "Send Info";
            this.sendInfoButton.UseVisualStyleBackColor = true;
            this.sendInfoButton.Click += new System.EventHandler(this.SendInfoButton_Click);
            // 
            // sendValueButton
            // 
            this.sendValueButton.Location = new System.Drawing.Point(6, 19);
            this.sendValueButton.Name = "sendValueButton";
            this.sendValueButton.Size = new System.Drawing.Size(103, 23);
            this.sendValueButton.TabIndex = 7;
            this.sendValueButton.Text = "Send Value";
            this.sendValueButton.UseVisualStyleBackColor = true;
            this.sendValueButton.Click += new System.EventHandler(this.SendValueButton_Click);
            // 
            // connectionChooserComboBox
            // 
            this.connectionChooserComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.connectionChooserComboBox.FormattingEnabled = true;
            this.connectionChooserComboBox.Location = new System.Drawing.Point(6, 19);
            this.connectionChooserComboBox.Name = "connectionChooserComboBox";
            this.connectionChooserComboBox.Size = new System.Drawing.Size(165, 21);
            this.connectionChooserComboBox.Sorted = true;
            this.connectionChooserComboBox.TabIndex = 8;
            this.connectionChooserComboBox.SelectedIndexChanged += new System.EventHandler(this.ConnectionChooserComboBox_SelectedIndexChanged);
            // 
            // settingsButton
            // 
            this.settingsButton.AutoSize = true;
            this.settingsButton.Location = new System.Drawing.Point(177, 18);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(103, 27);
            this.settingsButton.TabIndex = 9;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // stopSendingButton
            // 
            this.stopSendingButton.Location = new System.Drawing.Point(6, 48);
            this.stopSendingButton.Name = "stopSendingButton";
            this.stopSendingButton.Size = new System.Drawing.Size(103, 23);
            this.stopSendingButton.TabIndex = 10;
            this.stopSendingButton.Text = "Stop sending";
            this.stopSendingButton.UseVisualStyleBackColor = true;
            this.stopSendingButton.Click += new System.EventHandler(this.StopSendingButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.connectionChooserComboBox);
            this.groupBox1.Controls.Add(this.settingsButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 50);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connector";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(292, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(158, 109);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SaveConfigFileButton);
            this.groupBox2.Controls.Add(this.openServerButton);
            this.groupBox2.Controls.Add(this.closeServerButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 53);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server status";
            // 
            // sendingGroupBox
            // 
            this.sendingGroupBox.Controls.Add(this.MultipleNodesConfigGroupBox);
            this.sendingGroupBox.Controls.Add(this.SimulateMultipleNodes);
            this.sendingGroupBox.Controls.Add(this.ResponsesGroupBox);
            this.sendingGroupBox.Controls.Add(this.AutoRespondCheckbox);
            this.sendingGroupBox.Controls.Add(this.groupBox3);
            this.sendingGroupBox.Enabled = false;
            this.sendingGroupBox.Location = new System.Drawing.Point(12, 127);
            this.sendingGroupBox.Name = "sendingGroupBox";
            this.sendingGroupBox.Size = new System.Drawing.Size(450, 157);
            this.sendingGroupBox.TabIndex = 13;
            this.sendingGroupBox.TabStop = false;
            this.sendingGroupBox.Text = "Sending";
            // 
            // SaveConfigFileButton
            // 
            this.SaveConfigFileButton.Location = new System.Drawing.Point(177, 19);
            this.SaveConfigFileButton.Name = "SaveConfigFileButton";
            this.SaveConfigFileButton.Size = new System.Drawing.Size(103, 23);
            this.SaveConfigFileButton.TabIndex = 17;
            this.SaveConfigFileButton.Text = "Save config";
            this.SaveConfigFileButton.UseVisualStyleBackColor = true;
            this.SaveConfigFileButton.Click += new System.EventHandler(this.SaveConfigFileButton_Click);
            // 
            // MultipleNodesConfigGroupBox
            // 
            this.MultipleNodesConfigGroupBox.Controls.Add(this.label3);
            this.MultipleNodesConfigGroupBox.Controls.Add(this.numericUpDown1);
            this.MultipleNodesConfigGroupBox.Enabled = false;
            this.MultipleNodesConfigGroupBox.Location = new System.Drawing.Point(165, 42);
            this.MultipleNodesConfigGroupBox.Name = "MultipleNodesConfigGroupBox";
            this.MultipleNodesConfigGroupBox.Size = new System.Drawing.Size(136, 109);
            this.MultipleNodesConfigGroupBox.TabIndex = 16;
            this.MultipleNodesConfigGroupBox.TabStop = false;
            this.MultipleNodesConfigGroupBox.Text = "Multiple nodes config";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "# of nodes";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(70, 20);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // SimulateMultipleNodes
            // 
            this.SimulateMultipleNodes.AutoSize = true;
            this.SimulateMultipleNodes.Location = new System.Drawing.Point(165, 19);
            this.SimulateMultipleNodes.Name = "SimulateMultipleNodes";
            this.SimulateMultipleNodes.Size = new System.Drawing.Size(136, 17);
            this.SimulateMultipleNodes.TabIndex = 15;
            this.SimulateMultipleNodes.Text = "Simulate multiple nodes";
            this.SimulateMultipleNodes.UseVisualStyleBackColor = true;
            this.SimulateMultipleNodes.CheckedChanged += new System.EventHandler(this.SimulateMultipleNodes_CheckedChanged);
            // 
            // ResponsesGroupBox
            // 
            this.ResponsesGroupBox.Controls.Add(this.sendVersionButton);
            this.ResponsesGroupBox.Controls.Add(this.sendInfoButton);
            this.ResponsesGroupBox.Controls.Add(this.SendConfigButton);
            this.ResponsesGroupBox.Enabled = false;
            this.ResponsesGroupBox.Location = new System.Drawing.Point(6, 42);
            this.ResponsesGroupBox.Name = "ResponsesGroupBox";
            this.ResponsesGroupBox.Size = new System.Drawing.Size(119, 109);
            this.ResponsesGroupBox.TabIndex = 14;
            this.ResponsesGroupBox.TabStop = false;
            this.ResponsesGroupBox.Text = "Responses";
            // 
            // SendConfigButton
            // 
            this.SendConfigButton.Location = new System.Drawing.Point(6, 77);
            this.SendConfigButton.Name = "SendConfigButton";
            this.SendConfigButton.Size = new System.Drawing.Size(103, 23);
            this.SendConfigButton.TabIndex = 11;
            this.SendConfigButton.Text = "Send Config";
            this.SendConfigButton.UseVisualStyleBackColor = true;
            this.SendConfigButton.Click += new System.EventHandler(this.SendConfigButton_Click);
            // 
            // AutoRespondCheckbox
            // 
            this.AutoRespondCheckbox.AutoSize = true;
            this.AutoRespondCheckbox.Checked = true;
            this.AutoRespondCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoRespondCheckbox.Location = new System.Drawing.Point(12, 19);
            this.AutoRespondCheckbox.Name = "AutoRespondCheckbox";
            this.AutoRespondCheckbox.Size = new System.Drawing.Size(89, 17);
            this.AutoRespondCheckbox.TabIndex = 13;
            this.AutoRespondCheckbox.Text = "Auto-respond";
            this.AutoRespondCheckbox.UseVisualStyleBackColor = true;
            this.AutoRespondCheckbox.CheckedChanged += new System.EventHandler(this.AutoRespondCheckbox_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sendValueButton);
            this.groupBox3.Controls.Add(this.stopSendingButton);
            this.groupBox3.Location = new System.Drawing.Point(330, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(114, 83);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sine";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.StringTextBox);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.IntTextBox);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.BoolButton);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(310, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(152, 109);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "My Values";
            // 
            // StringTextBox
            // 
            this.StringTextBox.Location = new System.Drawing.Point(66, 63);
            this.StringTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.StringTextBox.Name = "StringTextBox";
            this.StringTextBox.Size = new System.Drawing.Size(75, 20);
            this.StringTextBox.TabIndex = 5;
            this.StringTextBox.TextChanged += new System.EventHandler(this.StringTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "String";
            // 
            // IntTextBox
            // 
            this.IntTextBox.Enabled = false;
            this.IntTextBox.Location = new System.Drawing.Point(66, 40);
            this.IntTextBox.Name = "IntTextBox";
            this.IntTextBox.Size = new System.Drawing.Size(75, 20);
            this.IntTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "int";
            // 
            // BoolButton
            // 
            this.BoolButton.BackColor = System.Drawing.Color.Red;
            this.BoolButton.Location = new System.Drawing.Point(66, 11);
            this.BoolButton.Name = "BoolButton";
            this.BoolButton.Size = new System.Drawing.Size(75, 23);
            this.BoolButton.TabIndex = 1;
            this.BoolButton.UseVisualStyleBackColor = false;
            this.BoolButton.Click += new System.EventHandler(this.BoolButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "boolean";
            // 
            // embeddedTerminal1
            // 
            this.embeddedTerminal1.AcceptsReturn = true;
            this.embeddedTerminal1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.embeddedTerminal1.BackColor = System.Drawing.Color.Black;
            this.embeddedTerminal1.ForeColor = System.Drawing.Color.White;
            this.embeddedTerminal1.Location = new System.Drawing.Point(13, 290);
            this.embeddedTerminal1.Multiline = true;
            this.embeddedTerminal1.Name = "embeddedTerminal1";
            this.embeddedTerminal1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.embeddedTerminal1.Size = new System.Drawing.Size(449, 92);
            this.embeddedTerminal1.TabIndex = 15;
            this.embeddedTerminal1.Text = "To:\t";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(474, 388);
            this.Controls.Add(this.embeddedTerminal1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.sendingGroupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Embedded Emulator V0.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.sendingGroupBox.ResumeLayout(false);
            this.sendingGroupBox.PerformLayout();
            this.MultipleNodesConfigGroupBox.ResumeLayout(false);
            this.MultipleNodesConfigGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResponsesGroupBox.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button openServerButton;
        private System.Windows.Forms.Button closeServerButton;
        private System.Windows.Forms.Button sendVersionButton;
        private System.Windows.Forms.Button sendInfoButton;
        private System.Windows.Forms.Button sendValueButton;
        private System.Windows.Forms.ComboBox connectionChooserComboBox;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button stopSendingButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox sendingGroupBox;
        private System.Windows.Forms.Button SendConfigButton;
        private System.Windows.Forms.CheckBox AutoRespondCheckbox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button BoolButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox ResponsesGroupBox;
        private System.Windows.Forms.TextBox IntTextBox;
        private System.Windows.Forms.Label label2;
        private EmbeddedDebugger.View.CustomComponents.EmbeddedTerminal embeddedTerminal1;
        private System.Windows.Forms.GroupBox MultipleNodesConfigGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox SimulateMultipleNodes;
        private System.Windows.Forms.TextBox StringTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SaveConfigFileButton;
    }
}

