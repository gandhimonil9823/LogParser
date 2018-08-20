<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.OpenFileDialogAgentResult = New System.Windows.Forms.OpenFileDialog()
        Me.AgentButton = New System.Windows.Forms.Button()
        Me.AgentText = New System.Windows.Forms.TextBox()
        Me.AgentLabel = New System.Windows.Forms.Label()
        Me.ResultLabel = New System.Windows.Forms.Label()
        Me.ResultButton = New System.Windows.Forms.Button()
        Me.ResultText = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanelAgentResult = New System.Windows.Forms.TableLayoutPanel()
        Me.Jobs = New System.Windows.Forms.Label()
        Me.Results = New System.Windows.Forms.Label()
        Me.Submit = New System.Windows.Forms.Button()
        Me.TableLayoutPanelAgentResult.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialogAgentResult
        '
        Me.OpenFileDialogAgentResult.FileName = "OpenFileDialog1"
        '
        'AgentButton
        '
        Me.AgentButton.Location = New System.Drawing.Point(25, 38)
        Me.AgentButton.Name = "AgentButton"
        Me.AgentButton.Size = New System.Drawing.Size(75, 23)
        Me.AgentButton.TabIndex = 0
        Me.AgentButton.Text = "Load"
        Me.AgentButton.UseVisualStyleBackColor = True
        '
        'AgentText
        '
        Me.AgentText.Location = New System.Drawing.Point(119, 40)
        Me.AgentText.Name = "AgentText"
        Me.AgentText.Size = New System.Drawing.Size(157, 20)
        Me.AgentText.TabIndex = 1
        '
        'AgentLabel
        '
        Me.AgentLabel.AutoSize = True
        Me.AgentLabel.BackColor = System.Drawing.Color.Transparent
        Me.AgentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgentLabel.Location = New System.Drawing.Point(31, 9)
        Me.AgentLabel.Name = "AgentLabel"
        Me.AgentLabel.Size = New System.Drawing.Size(69, 17)
        Me.AgentLabel.TabIndex = 2
        Me.AgentLabel.Text = "AgentLog"
        '
        'ResultLabel
        '
        Me.ResultLabel.AutoSize = True
        Me.ResultLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ResultLabel.Location = New System.Drawing.Point(369, 9)
        Me.ResultLabel.Name = "ResultLabel"
        Me.ResultLabel.Size = New System.Drawing.Size(72, 17)
        Me.ResultLabel.TabIndex = 4
        Me.ResultLabel.Text = "ResultLog"
        '
        'ResultButton
        '
        Me.ResultButton.Location = New System.Drawing.Point(366, 37)
        Me.ResultButton.Name = "ResultButton"
        Me.ResultButton.Size = New System.Drawing.Size(75, 23)
        Me.ResultButton.TabIndex = 3
        Me.ResultButton.Text = "Load"
        Me.ResultButton.UseVisualStyleBackColor = True
        '
        'ResultText
        '
        Me.ResultText.Location = New System.Drawing.Point(458, 39)
        Me.ResultText.Name = "ResultText"
        Me.ResultText.Size = New System.Drawing.Size(172, 20)
        Me.ResultText.TabIndex = 5
        '
        'TableLayoutPanelAgentResult
        '
        Me.TableLayoutPanelAgentResult.ColumnCount = 2
        Me.TableLayoutPanelAgentResult.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.32362!))
        Me.TableLayoutPanelAgentResult.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.67638!))
        Me.TableLayoutPanelAgentResult.Controls.Add(Me.Jobs, 0, 0)
        Me.TableLayoutPanelAgentResult.Controls.Add(Me.Results, 1, 0)
        Me.TableLayoutPanelAgentResult.Location = New System.Drawing.Point(12, 103)
        Me.TableLayoutPanelAgentResult.Name = "TableLayoutPanelAgentResult"
        Me.TableLayoutPanelAgentResult.RowCount = 2
        Me.TableLayoutPanelAgentResult.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.780488!))
        Me.TableLayoutPanelAgentResult.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.21951!))
        Me.TableLayoutPanelAgentResult.Size = New System.Drawing.Size(618, 411)
        Me.TableLayoutPanelAgentResult.TabIndex = 6
        '
        'Jobs
        '
        Me.Jobs.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Jobs.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Jobs.Location = New System.Drawing.Point(3, 1)
        Me.Jobs.Name = "Jobs"
        Me.Jobs.Size = New System.Drawing.Size(303, 34)
        Me.Jobs.TabIndex = 0
        Me.Jobs.Text = "Jobs"
        Me.Jobs.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Results
        '
        Me.Results.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Results.AutoSize = True
        Me.Results.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Results.Location = New System.Drawing.Point(313, 2)
        Me.Results.Name = "Results"
        Me.Results.Size = New System.Drawing.Size(302, 31)
        Me.Results.TabIndex = 1
        Me.Results.Text = "Results"
        Me.Results.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Submit
        '
        Me.Submit.Location = New System.Drawing.Point(282, 74)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(75, 23)
        Me.Submit.TabIndex = 7
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(642, 537)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.TableLayoutPanelAgentResult)
        Me.Controls.Add(Me.ResultText)
        Me.Controls.Add(Me.ResultButton)
        Me.Controls.Add(Me.ResultLabel)
        Me.Controls.Add(Me.AgentLabel)
        Me.Controls.Add(Me.AgentText)
        Me.Controls.Add(Me.AgentButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TableLayoutPanelAgentResult.ResumeLayout(False)
        Me.TableLayoutPanelAgentResult.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialogAgentResult As OpenFileDialog

    Friend WithEvents AgentButton As Button
    Friend WithEvents AgentText As TextBox
    Friend WithEvents AgentLabel As Label
    Friend WithEvents ResultLabel As Label
    Friend WithEvents ResultButton As Button
    Friend WithEvents ResultText As TextBox
    Friend WithEvents TableLayoutPanelAgentResult As TableLayoutPanel
    Friend WithEvents Jobs As Label
    Friend WithEvents Results As Label
    Friend WithEvents Submit As Button
End Class
