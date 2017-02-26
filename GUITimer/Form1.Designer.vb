<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TimerApp
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TimeDisplay = New System.Windows.Forms.Label()
        Me.TimerMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopwatchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundColourDialog = New System.Windows.Forms.ColorDialog()
        Me.AlwaysOnTopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimerMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'TimeDisplay
        '
        Me.TimeDisplay.AutoSize = True
        Me.TimeDisplay.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeDisplay.Location = New System.Drawing.Point(10, 10)
        Me.TimeDisplay.Name = "TimeDisplay"
        Me.TimeDisplay.Size = New System.Drawing.Size(409, 128)
        Me.TimeDisplay.TabIndex = 0
        Me.TimeDisplay.Text = "00:00:00"
        '
        'TimerMenu
        '
        Me.TimerMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem, Me.StopToolStripMenuItem, Me.ToolStripSeparator1, Me.ModeToolStripMenuItem, Me.BackgroundToolStripMenuItem, Me.ResetMenuItem, Me.ToolStripSeparator2, Me.AlwaysOnTopToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.TimerMenu.Name = "ContextMenuStrip1"
        Me.TimerMenu.Size = New System.Drawing.Size(157, 192)
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.StartToolStripMenuItem.Text = "Start"
        '
        'StopToolStripMenuItem
        '
        Me.StopToolStripMenuItem.Name = "StopToolStripMenuItem"
        Me.StopToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.StopToolStripMenuItem.Text = "Stop"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(153, 6)
        '
        'ModeToolStripMenuItem
        '
        Me.ModeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TimerToolStripMenuItem, Me.StopwatchToolStripMenuItem})
        Me.ModeToolStripMenuItem.Name = "ModeToolStripMenuItem"
        Me.ModeToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ModeToolStripMenuItem.Text = "Mode"
        '
        'TimerToolStripMenuItem
        '
        Me.TimerToolStripMenuItem.Checked = True
        Me.TimerToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TimerToolStripMenuItem.Name = "TimerToolStripMenuItem"
        Me.TimerToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.TimerToolStripMenuItem.Text = "Timer"
        '
        'StopwatchToolStripMenuItem
        '
        Me.StopwatchToolStripMenuItem.Name = "StopwatchToolStripMenuItem"
        Me.StopwatchToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.StopwatchToolStripMenuItem.Text = "Stopwatch"
        '
        'BackgroundToolStripMenuItem
        '
        Me.BackgroundToolStripMenuItem.Name = "BackgroundToolStripMenuItem"
        Me.BackgroundToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.BackgroundToolStripMenuItem.Text = "Background"
        '
        'ResetMenuItem
        '
        Me.ResetMenuItem.Name = "ResetMenuItem"
        Me.ResetMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ResetMenuItem.Text = "Reset"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(153, 6)
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'BackgroundColourDialog
        '
        Me.BackgroundColourDialog.Color = System.Drawing.Color.White
        '
        'AlwaysOnTopToolStripMenuItem
        '
        Me.AlwaysOnTopToolStripMenuItem.Checked = True
        Me.AlwaysOnTopToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AlwaysOnTopToolStripMenuItem.Name = "AlwaysOnTopToolStripMenuItem"
        Me.AlwaysOnTopToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.AlwaysOnTopToolStripMenuItem.Text = "Always on Top"
        '
        'TimerApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(431, 155)
        Me.ContextMenuStrip = Me.TimerMenu
        Me.Controls.Add(Me.TimeDisplay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TimerApp"
        Me.Text = "Timer"
        Me.TopMost = True
        Me.TimerMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents TimeDisplay As Label
    Friend WithEvents TimerMenu As ContextMenuStrip
    Friend WithEvents StartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents BackgroundToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundColourDialog As ColorDialog
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StopwatchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents AlwaysOnTopToolStripMenuItem As ToolStripMenuItem
End Class
