<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DemoForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.connectionStringTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.commandTimeoutSecondsTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.inputPathTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.outputPathTextBox = New System.Windows.Forms.TextBox()
        Me.checkedValueCheckBox = New System.Windows.Forms.CheckBox()
        Me.listSelectedIndexComboBox = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ConnectionString:"
        '
        'connectionStringTextBox
        '
        Me.connectionStringTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.connectionStringTextBox.Location = New System.Drawing.Point(187, 12)
        Me.connectionStringTextBox.Name = "connectionStringTextBox"
        Me.connectionStringTextBox.ReadOnly = True
        Me.connectionStringTextBox.Size = New System.Drawing.Size(545, 23)
        Me.connectionStringTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CommandTimeoutSeconds:"
        '
        'commandTimeoutSecondsTextBox
        '
        Me.commandTimeoutSecondsTextBox.Location = New System.Drawing.Point(187, 41)
        Me.commandTimeoutSecondsTextBox.Name = "commandTimeoutSecondsTextBox"
        Me.commandTimeoutSecondsTextBox.ReadOnly = True
        Me.commandTimeoutSecondsTextBox.Size = New System.Drawing.Size(127, 23)
        Me.commandTimeoutSecondsTextBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "InputPath:"
        '
        'inputPathTextBox
        '
        Me.inputPathTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.inputPathTextBox.Location = New System.Drawing.Point(187, 70)
        Me.inputPathTextBox.Name = "inputPathTextBox"
        Me.inputPathTextBox.Size = New System.Drawing.Size(545, 23)
        Me.inputPathTextBox.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "OutputPath:"
        '
        'outputPathTextBox
        '
        Me.outputPathTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.outputPathTextBox.Location = New System.Drawing.Point(187, 99)
        Me.outputPathTextBox.Name = "outputPathTextBox"
        Me.outputPathTextBox.Size = New System.Drawing.Size(545, 23)
        Me.outputPathTextBox.TabIndex = 7
        '
        'checkedValueCheckBox
        '
        Me.checkedValueCheckBox.AutoSize = True
        Me.checkedValueCheckBox.Location = New System.Drawing.Point(187, 128)
        Me.checkedValueCheckBox.Name = "checkedValueCheckBox"
        Me.checkedValueCheckBox.Size = New System.Drawing.Size(106, 19)
        Me.checkedValueCheckBox.TabIndex = 8
        Me.checkedValueCheckBox.Text = "CheckedValue"
        Me.checkedValueCheckBox.UseVisualStyleBackColor = True
        '
        'listSelectedIndexComboBox
        '
        Me.listSelectedIndexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.listSelectedIndexComboBox.FormattingEnabled = True
        Me.listSelectedIndexComboBox.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.listSelectedIndexComboBox.Location = New System.Drawing.Point(187, 153)
        Me.listSelectedIndexComboBox.Name = "listSelectedIndexComboBox"
        Me.listSelectedIndexComboBox.Size = New System.Drawing.Size(121, 23)
        Me.listSelectedIndexComboBox.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "ListSelectedIndex:"
        '
        'DemoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 201)
        Me.Controls.Add(Me.listSelectedIndexComboBox)
        Me.Controls.Add(Me.checkedValueCheckBox)
        Me.Controls.Add(Me.outputPathTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.inputPathTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.commandTimeoutSecondsTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.connectionStringTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "DemoForm"
        Me.Text = "Switchable Settings Sample"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents connectionStringTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents commandTimeoutSecondsTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents inputPathTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents outputPathTextBox As TextBox
    Friend WithEvents checkedValueCheckBox As CheckBox
    Friend WithEvents listSelectedIndexComboBox As ComboBox
    Friend WithEvents Label5 As Label
End Class
