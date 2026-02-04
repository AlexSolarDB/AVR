<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WelcomeForm
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WelcomeForm))
        Me.lblWelcomeInfo = New System.Windows.Forms.Label()
        Me.btnWelcomeDocs = New System.Windows.Forms.Button()
        Me.btnWelcomeTable = New System.Windows.Forms.Button()
        Me.btnWelcomeSettings = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblWelcomeInfo
        '
        Me.lblWelcomeInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWelcomeInfo.Location = New System.Drawing.Point(15, 15)
        Me.lblWelcomeInfo.Margin = New System.Windows.Forms.Padding(15)
        Me.lblWelcomeInfo.MinimumSize = New System.Drawing.Size(350, 25)
        Me.lblWelcomeInfo.Name = "lblWelcomeInfo"
        Me.lblWelcomeInfo.Size = New System.Drawing.Size(515, 25)
        Me.lblWelcomeInfo.TabIndex = 0
        Me.lblWelcomeInfo.Text = "Здравствуйте, уважаемый пользователь!"
        Me.lblWelcomeInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnWelcomeDocs
        '
        Me.btnWelcomeDocs.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnWelcomeDocs.Location = New System.Drawing.Point(15, 55)
        Me.btnWelcomeDocs.Margin = New System.Windows.Forms.Padding(15)
        Me.btnWelcomeDocs.MinimumSize = New System.Drawing.Size(350, 25)
        Me.btnWelcomeDocs.Name = "btnWelcomeDocs"
        Me.btnWelcomeDocs.Size = New System.Drawing.Size(515, 25)
        Me.btnWelcomeDocs.TabIndex = 1
        Me.btnWelcomeDocs.Text = "Работа с документами"
        Me.btnWelcomeDocs.UseVisualStyleBackColor = True
        '
        'btnWelcomeTable
        '
        Me.btnWelcomeTable.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnWelcomeTable.Location = New System.Drawing.Point(15, 95)
        Me.btnWelcomeTable.Margin = New System.Windows.Forms.Padding(15)
        Me.btnWelcomeTable.MinimumSize = New System.Drawing.Size(350, 25)
        Me.btnWelcomeTable.Name = "btnWelcomeTable"
        Me.btnWelcomeTable.Size = New System.Drawing.Size(515, 25)
        Me.btnWelcomeTable.TabIndex = 2
        Me.btnWelcomeTable.Text = "Работа с таблицами"
        Me.btnWelcomeTable.UseVisualStyleBackColor = True
        '
        'btnWelcomeSettings
        '
        Me.btnWelcomeSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnWelcomeSettings.Location = New System.Drawing.Point(15, 135)
        Me.btnWelcomeSettings.Margin = New System.Windows.Forms.Padding(15)
        Me.btnWelcomeSettings.MinimumSize = New System.Drawing.Size(350, 25)
        Me.btnWelcomeSettings.Name = "btnWelcomeSettings"
        Me.btnWelcomeSettings.Size = New System.Drawing.Size(515, 25)
        Me.btnWelcomeSettings.TabIndex = 3
        Me.btnWelcomeSettings.Text = "Настройки"
        Me.btnWelcomeSettings.UseVisualStyleBackColor = True
        '
        'WelcomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(545, 175)
        Me.Controls.Add(Me.btnWelcomeSettings)
        Me.Controls.Add(Me.btnWelcomeTable)
        Me.Controls.Add(Me.btnWelcomeDocs)
        Me.Controls.Add(Me.lblWelcomeInfo)
        Me.Font = New System.Drawing.Font("Maple Mono", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MinimumSize = New System.Drawing.Size(396, 214)
        Me.Name = "WelcomeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Главное окно"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblWelcomeInfo As Label
    Friend WithEvents btnWelcomeDocs As Button
    Friend WithEvents btnWelcomeTable As Button
    Friend WithEvents btnWelcomeSettings As Button
End Class
