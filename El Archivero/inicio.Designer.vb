<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inicio))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RadialMenu1 = New DevExpress.XtraBars.Ribbon.RadialMenu(Me.components)
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.AxTfrxPreviewX1 = New AxFastReport.AxTfrxPreviewX()
        Me.AxTfrxPreviewX2 = New AxFastReport.AxTfrxPreviewX()
        Me.AxTfrxActivePreviewForm1 = New AxFastReport.AxTfrxActivePreviewForm()
        CType(Me.RadialMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxTfrxPreviewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxTfrxPreviewX2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxTfrxActivePreviewForm1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadialMenu1
        '
        Me.RadialMenu1.Name = "RadialMenu1"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.Name = "SqlDataSource1"
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(42, 53)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(121, 97)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'AxTfrxPreviewX1
        '
        Me.AxTfrxPreviewX1.Location = New System.Drawing.Point(126, 14)
        Me.AxTfrxPreviewX1.Name = "AxTfrxPreviewX1"
        Me.AxTfrxPreviewX1.OcxState = CType(resources.GetObject("AxTfrxPreviewX1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxTfrxPreviewX1.Size = New System.Drawing.Size(75, 23)
        Me.AxTfrxPreviewX1.TabIndex = 1
        '
        'AxTfrxPreviewX2
        '
        Me.AxTfrxPreviewX2.Location = New System.Drawing.Point(126, 184)
        Me.AxTfrxPreviewX2.Name = "AxTfrxPreviewX2"
        Me.AxTfrxPreviewX2.OcxState = CType(resources.GetObject("AxTfrxPreviewX2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxTfrxPreviewX2.Size = New System.Drawing.Size(75, 23)
        Me.AxTfrxPreviewX2.TabIndex = 2
        '
        'AxTfrxActivePreviewForm1
        '
        Me.AxTfrxActivePreviewForm1.Location = New System.Drawing.Point(203, 120)
        Me.AxTfrxActivePreviewForm1.Name = "AxTfrxActivePreviewForm1"
        Me.AxTfrxActivePreviewForm1.OcxState = CType(resources.GetObject("AxTfrxActivePreviewForm1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxTfrxActivePreviewForm1.Size = New System.Drawing.Size(75, 23)
        Me.AxTfrxActivePreviewForm1.TabIndex = 3
        '
        'inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.AxTfrxActivePreviewForm1)
        Me.Controls.Add(Me.AxTfrxPreviewX2)
        Me.Controls.Add(Me.AxTfrxPreviewX1)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "inicio"
        Me.Text = "Form1"
        CType(Me.RadialMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxTfrxPreviewX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxTfrxPreviewX2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxTfrxActivePreviewForm1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents RadialMenu1 As DevExpress.XtraBars.Ribbon.RadialMenu
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents ListView1 As ListView
    Friend WithEvents AxTfrxPreviewX1 As AxFastReport.AxTfrxPreviewX
    Friend WithEvents AxTfrxPreviewX2 As AxFastReport.AxTfrxPreviewX
    Friend WithEvents AxTfrxActivePreviewForm1 As AxFastReport.AxTfrxActivePreviewForm
End Class
