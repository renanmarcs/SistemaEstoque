﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_planoContas
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_planoContas))
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.tab_cadastro = New System.Windows.Forms.TabControl()
        Me.tab_ativo = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_vtotal_ativo = New System.Windows.Forms.Label()
        Me.lbl_vunit_ativo = New System.Windows.Forms.Label()
        Me.cmb_categoria_ativo = New System.Windows.Forms.ComboBox()
        Me.cmb_tipo_ativo = New System.Windows.Forms.ComboBox()
        Me.lbl_tipo_ativo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_cadastrar_ativo = New System.Windows.Forms.Button()
        Me.txt_vtotal_ativo = New System.Windows.Forms.TextBox()
        Me.txt_vunit_ativo = New System.Windows.Forms.TextBox()
        Me.txt_qtd_ativo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_desc_ativo = New System.Windows.Forms.TextBox()
        Me.txt_nome_ativo = New System.Windows.Forms.TextBox()
        Me.tab_passivo = New System.Windows.Forms.TabPage()
        Me.lbl_vtotal_passivo = New System.Windows.Forms.Label()
        Me.lbl_vunit_passivo = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmb_categoria_passivo = New System.Windows.Forms.ComboBox()
        Me.cmb_tipo_passivo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_vtotal_passivo = New System.Windows.Forms.TextBox()
        Me.txt_vunit_passivo = New System.Windows.Forms.TextBox()
        Me.txt_qtd_passivo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_desc_passivo = New System.Windows.Forms.TextBox()
        Me.txt_nome_passivo = New System.Windows.Forms.TextBox()
        Me.btn_cadastrar_passivo = New System.Windows.Forms.Button()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.tab_cadastro.SuspendLayout()
        Me.tab_ativo.SuspendLayout()
        Me.tab_passivo.SuspendLayout()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView1.BackColor = System.Drawing.Color.White
        Me.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeView1.Font = New System.Drawing.Font("Bernard MT Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.Location = New System.Drawing.Point(34, 58)
        Me.TreeView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(353, 587)
        Me.TreeView1.TabIndex = 0
        '
        'tab_cadastro
        '
        Me.tab_cadastro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tab_cadastro.Controls.Add(Me.tab_ativo)
        Me.tab_cadastro.Controls.Add(Me.tab_passivo)
        Me.tab_cadastro.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_cadastro.Location = New System.Drawing.Point(398, 18)
        Me.tab_cadastro.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tab_cadastro.Name = "tab_cadastro"
        Me.tab_cadastro.SelectedIndex = 0
        Me.tab_cadastro.Size = New System.Drawing.Size(948, 703)
        Me.tab_cadastro.TabIndex = 1
        '
        'tab_ativo
        '
        Me.tab_ativo.BackColor = System.Drawing.Color.White
        Me.tab_ativo.Controls.Add(Me.Label6)
        Me.tab_ativo.Controls.Add(Me.lbl_vtotal_ativo)
        Me.tab_ativo.Controls.Add(Me.lbl_vunit_ativo)
        Me.tab_ativo.Controls.Add(Me.cmb_categoria_ativo)
        Me.tab_ativo.Controls.Add(Me.cmb_tipo_ativo)
        Me.tab_ativo.Controls.Add(Me.lbl_tipo_ativo)
        Me.tab_ativo.Controls.Add(Me.Label4)
        Me.tab_ativo.Controls.Add(Me.Label1)
        Me.tab_ativo.Controls.Add(Me.btn_cadastrar_ativo)
        Me.tab_ativo.Controls.Add(Me.txt_vtotal_ativo)
        Me.tab_ativo.Controls.Add(Me.txt_vunit_ativo)
        Me.tab_ativo.Controls.Add(Me.txt_qtd_ativo)
        Me.tab_ativo.Controls.Add(Me.Label3)
        Me.tab_ativo.Controls.Add(Me.txt_desc_ativo)
        Me.tab_ativo.Controls.Add(Me.txt_nome_ativo)
        Me.tab_ativo.Location = New System.Drawing.Point(4, 34)
        Me.tab_ativo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tab_ativo.Name = "tab_ativo"
        Me.tab_ativo.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tab_ativo.Size = New System.Drawing.Size(940, 665)
        Me.tab_ativo.TabIndex = 0
        Me.tab_ativo.Text = "ATIVO"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label6.Location = New System.Drawing.Point(66, 549)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 71)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Quan - tidade"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_vtotal_ativo
        '
        Me.lbl_vtotal_ativo.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_vtotal_ativo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl_vtotal_ativo.Location = New System.Drawing.Point(390, 549)
        Me.lbl_vtotal_ativo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_vtotal_ativo.Name = "lbl_vtotal_ativo"
        Me.lbl_vtotal_ativo.Size = New System.Drawing.Size(116, 71)
        Me.lbl_vtotal_ativo.TabIndex = 58
        Me.lbl_vtotal_ativo.Text = "Valor Total"
        Me.lbl_vtotal_ativo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_vunit_ativo
        '
        Me.lbl_vunit_ativo.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_vunit_ativo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl_vunit_ativo.Location = New System.Drawing.Point(212, 549)
        Me.lbl_vunit_ativo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_vunit_ativo.Name = "lbl_vunit_ativo"
        Me.lbl_vunit_ativo.Size = New System.Drawing.Size(152, 71)
        Me.lbl_vunit_ativo.TabIndex = 57
        Me.lbl_vunit_ativo.Text = "Valor Unitário"
        Me.lbl_vunit_ativo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmb_categoria_ativo
        '
        Me.cmb_categoria_ativo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_categoria_ativo.FormattingEnabled = True
        Me.cmb_categoria_ativo.Items.AddRange(New Object() {"Bebidas", "Comidas", "Eletrônicos", "Eletrodomésticos"})
        Me.cmb_categoria_ativo.Location = New System.Drawing.Point(537, 489)
        Me.cmb_categoria_ativo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmb_categoria_ativo.Name = "cmb_categoria_ativo"
        Me.cmb_categoria_ativo.Size = New System.Drawing.Size(316, 33)
        Me.cmb_categoria_ativo.TabIndex = 46
        '
        'cmb_tipo_ativo
        '
        Me.cmb_tipo_ativo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_ativo.FormattingEnabled = True
        Me.cmb_tipo_ativo.Items.AddRange(New Object() {"Compra", "Venda"})
        Me.cmb_tipo_ativo.Location = New System.Drawing.Point(676, 157)
        Me.cmb_tipo_ativo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmb_tipo_ativo.Name = "cmb_tipo_ativo"
        Me.cmb_tipo_ativo.Size = New System.Drawing.Size(205, 33)
        Me.cmb_tipo_ativo.TabIndex = 45
        '
        'lbl_tipo_ativo
        '
        Me.lbl_tipo_ativo.AutoSize = True
        Me.lbl_tipo_ativo.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipo_ativo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl_tipo_ativo.Location = New System.Drawing.Point(608, 452)
        Me.lbl_tipo_ativo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_tipo_ativo.Name = "lbl_tipo_ativo"
        Me.lbl_tipo_ativo.Size = New System.Drawing.Size(165, 34)
        Me.lbl_tipo_ativo.TabIndex = 44
        Me.lbl_tipo_ativo.Text = "Categoria:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Location = New System.Drawing.Point(52, 223)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(380, 34)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Descrição da Mercadoria:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(28, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 55)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "ATIVO"
        '
        'btn_cadastrar_ativo
        '
        Me.btn_cadastrar_ativo.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastrar_ativo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btn_cadastrar_ativo.Image = CType(resources.GetObject("btn_cadastrar_ativo.Image"), System.Drawing.Image)
        Me.btn_cadastrar_ativo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cadastrar_ativo.Location = New System.Drawing.Point(590, 554)
        Me.btn_cadastrar_ativo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_cadastrar_ativo.Name = "btn_cadastrar_ativo"
        Me.btn_cadastrar_ativo.Size = New System.Drawing.Size(216, 55)
        Me.btn_cadastrar_ativo.TabIndex = 39
        Me.btn_cadastrar_ativo.Text = "Cadastrar"
        Me.btn_cadastrar_ativo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cadastrar_ativo.UseVisualStyleBackColor = True
        '
        'txt_vtotal_ativo
        '
        Me.txt_vtotal_ativo.Enabled = False
        Me.txt_vtotal_ativo.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_vtotal_ativo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_vtotal_ativo.Location = New System.Drawing.Point(390, 454)
        Me.txt_vtotal_ativo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_vtotal_ativo.Multiline = True
        Me.txt_vtotal_ativo.Name = "txt_vtotal_ativo"
        Me.txt_vtotal_ativo.Size = New System.Drawing.Size(114, 89)
        Me.txt_vtotal_ativo.TabIndex = 35
        '
        'txt_vunit_ativo
        '
        Me.txt_vunit_ativo.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_vunit_ativo.Location = New System.Drawing.Point(231, 454)
        Me.txt_vunit_ativo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_vunit_ativo.Multiline = True
        Me.txt_vunit_ativo.Name = "txt_vunit_ativo"
        Me.txt_vunit_ativo.Size = New System.Drawing.Size(114, 89)
        Me.txt_vunit_ativo.TabIndex = 34
        '
        'txt_qtd_ativo
        '
        Me.txt_qtd_ativo.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qtd_ativo.Location = New System.Drawing.Point(72, 454)
        Me.txt_qtd_ativo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_qtd_ativo.Multiline = True
        Me.txt_qtd_ativo.Name = "txt_qtd_ativo"
        Me.txt_qtd_ativo.Size = New System.Drawing.Size(114, 89)
        Me.txt_qtd_ativo.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(52, 118)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 34)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Nome"
        '
        'txt_desc_ativo
        '
        Me.txt_desc_ativo.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_desc_ativo.Location = New System.Drawing.Point(58, 260)
        Me.txt_desc_ativo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_desc_ativo.Multiline = True
        Me.txt_desc_ativo.Name = "txt_desc_ativo"
        Me.txt_desc_ativo.Size = New System.Drawing.Size(823, 166)
        Me.txt_desc_ativo.TabIndex = 30
        '
        'txt_nome_ativo
        '
        Me.txt_nome_ativo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txt_nome_ativo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_nome_ativo.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome_ativo.Location = New System.Drawing.Point(58, 157)
        Me.txt_nome_ativo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_nome_ativo.Name = "txt_nome_ativo"
        Me.txt_nome_ativo.Size = New System.Drawing.Size(607, 36)
        Me.txt_nome_ativo.TabIndex = 29
        '
        'tab_passivo
        '
        Me.tab_passivo.Controls.Add(Me.lbl_vtotal_passivo)
        Me.tab_passivo.Controls.Add(Me.lbl_vunit_passivo)
        Me.tab_passivo.Controls.Add(Me.Label12)
        Me.tab_passivo.Controls.Add(Me.cmb_categoria_passivo)
        Me.tab_passivo.Controls.Add(Me.cmb_tipo_passivo)
        Me.tab_passivo.Controls.Add(Me.Label2)
        Me.tab_passivo.Controls.Add(Me.Label8)
        Me.tab_passivo.Controls.Add(Me.Label9)
        Me.tab_passivo.Controls.Add(Me.txt_vtotal_passivo)
        Me.tab_passivo.Controls.Add(Me.txt_vunit_passivo)
        Me.tab_passivo.Controls.Add(Me.txt_qtd_passivo)
        Me.tab_passivo.Controls.Add(Me.Label13)
        Me.tab_passivo.Controls.Add(Me.txt_desc_passivo)
        Me.tab_passivo.Controls.Add(Me.txt_nome_passivo)
        Me.tab_passivo.Controls.Add(Me.btn_cadastrar_passivo)
        Me.tab_passivo.Location = New System.Drawing.Point(4, 34)
        Me.tab_passivo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tab_passivo.Name = "tab_passivo"
        Me.tab_passivo.Size = New System.Drawing.Size(940, 665)
        Me.tab_passivo.TabIndex = 1
        Me.tab_passivo.Text = "PASSIVO"
        Me.tab_passivo.UseVisualStyleBackColor = True
        '
        'lbl_vtotal_passivo
        '
        Me.lbl_vtotal_passivo.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_vtotal_passivo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl_vtotal_passivo.Location = New System.Drawing.Point(388, 546)
        Me.lbl_vtotal_passivo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_vtotal_passivo.Name = "lbl_vtotal_passivo"
        Me.lbl_vtotal_passivo.Size = New System.Drawing.Size(122, 71)
        Me.lbl_vtotal_passivo.TabIndex = 63
        Me.lbl_vtotal_passivo.Text = "Valor Total"
        Me.lbl_vtotal_passivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_vunit_passivo
        '
        Me.lbl_vunit_passivo.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_vunit_passivo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl_vunit_passivo.Location = New System.Drawing.Point(214, 549)
        Me.lbl_vunit_passivo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_vunit_passivo.Name = "lbl_vunit_passivo"
        Me.lbl_vunit_passivo.Size = New System.Drawing.Size(150, 71)
        Me.lbl_vunit_passivo.TabIndex = 62
        Me.lbl_vunit_passivo.Text = "Valor Unitário"
        Me.lbl_vunit_passivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label12.Location = New System.Drawing.Point(70, 549)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(122, 71)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "Quan - tidade"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmb_categoria_passivo
        '
        Me.cmb_categoria_passivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_categoria_passivo.FormattingEnabled = True
        Me.cmb_categoria_passivo.Items.AddRange(New Object() {"Bebidas", "Comidas", "Eletrônicos", "Eletrodomésticos"})
        Me.cmb_categoria_passivo.Location = New System.Drawing.Point(538, 486)
        Me.cmb_categoria_passivo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmb_categoria_passivo.Name = "cmb_categoria_passivo"
        Me.cmb_categoria_passivo.Size = New System.Drawing.Size(319, 33)
        Me.cmb_categoria_passivo.TabIndex = 61
        '
        'cmb_tipo_passivo
        '
        Me.cmb_tipo_passivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_passivo.FormattingEnabled = True
        Me.cmb_tipo_passivo.Items.AddRange(New Object() {"Compra", "Venda"})
        Me.cmb_tipo_passivo.Location = New System.Drawing.Point(676, 157)
        Me.cmb_tipo_passivo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmb_tipo_passivo.Name = "cmb_tipo_passivo"
        Me.cmb_tipo_passivo.Size = New System.Drawing.Size(205, 33)
        Me.cmb_tipo_passivo.TabIndex = 60
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(614, 448)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 34)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Categoria:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label8.Location = New System.Drawing.Point(52, 223)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(380, 34)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Descrição da Mercadoria:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Cooper Black", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label9.Location = New System.Drawing.Point(28, 31)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(255, 55)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "PASSIVO"
        '
        'txt_vtotal_passivo
        '
        Me.txt_vtotal_passivo.Enabled = False
        Me.txt_vtotal_passivo.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_vtotal_passivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_vtotal_passivo.Location = New System.Drawing.Point(394, 454)
        Me.txt_vtotal_passivo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_vtotal_passivo.Multiline = True
        Me.txt_vtotal_passivo.Name = "txt_vtotal_passivo"
        Me.txt_vtotal_passivo.Size = New System.Drawing.Size(114, 89)
        Me.txt_vtotal_passivo.TabIndex = 52
        '
        'txt_vunit_passivo
        '
        Me.txt_vunit_passivo.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_vunit_passivo.Location = New System.Drawing.Point(236, 454)
        Me.txt_vunit_passivo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_vunit_passivo.Multiline = True
        Me.txt_vunit_passivo.Name = "txt_vunit_passivo"
        Me.txt_vunit_passivo.Size = New System.Drawing.Size(114, 89)
        Me.txt_vunit_passivo.TabIndex = 51
        '
        'txt_qtd_passivo
        '
        Me.txt_qtd_passivo.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qtd_passivo.Location = New System.Drawing.Point(76, 454)
        Me.txt_qtd_passivo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_qtd_passivo.Multiline = True
        Me.txt_qtd_passivo.Name = "txt_qtd_passivo"
        Me.txt_qtd_passivo.Size = New System.Drawing.Size(114, 89)
        Me.txt_qtd_passivo.TabIndex = 50
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label13.Location = New System.Drawing.Point(52, 118)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(99, 34)
        Me.Label13.TabIndex = 49
        Me.Label13.Text = "Nome"
        '
        'txt_desc_passivo
        '
        Me.txt_desc_passivo.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_desc_passivo.Location = New System.Drawing.Point(58, 260)
        Me.txt_desc_passivo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_desc_passivo.Multiline = True
        Me.txt_desc_passivo.Name = "txt_desc_passivo"
        Me.txt_desc_passivo.Size = New System.Drawing.Size(823, 166)
        Me.txt_desc_passivo.TabIndex = 48
        '
        'txt_nome_passivo
        '
        Me.txt_nome_passivo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txt_nome_passivo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_nome_passivo.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome_passivo.Location = New System.Drawing.Point(58, 157)
        Me.txt_nome_passivo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_nome_passivo.Name = "txt_nome_passivo"
        Me.txt_nome_passivo.Size = New System.Drawing.Size(607, 36)
        Me.txt_nome_passivo.TabIndex = 47
        '
        'btn_cadastrar_passivo
        '
        Me.btn_cadastrar_passivo.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastrar_passivo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btn_cadastrar_passivo.Image = CType(resources.GetObject("btn_cadastrar_passivo.Image"), System.Drawing.Image)
        Me.btn_cadastrar_passivo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cadastrar_passivo.Location = New System.Drawing.Point(590, 554)
        Me.btn_cadastrar_passivo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_cadastrar_passivo.Name = "btn_cadastrar_passivo"
        Me.btn_cadastrar_passivo.Size = New System.Drawing.Size(216, 55)
        Me.btn_cadastrar_passivo.TabIndex = 56
        Me.btn_cadastrar_passivo.Text = "Cadastrar"
        Me.btn_cadastrar_passivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cadastrar_passivo.UseVisualStyleBackColor = True
        '
        'btn_voltar
        '
        Me.btn_voltar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_voltar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_voltar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_voltar.Font = New System.Drawing.Font("Cooper Black", 14.25!)
        Me.btn_voltar.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btn_voltar.Image = CType(resources.GetObject("btn_voltar.Image"), System.Drawing.Image)
        Me.btn_voltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_voltar.Location = New System.Drawing.Point(124, 655)
        Me.btn_voltar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(165, 60)
        Me.btn_voltar.TabIndex = 34
        Me.btn_voltar.Text = "Voltar"
        Me.btn_voltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'frm_planoContas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1364, 755)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.tab_cadastro)
        Me.Controls.Add(Me.TreeView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frm_planoContas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Plano de Contas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tab_cadastro.ResumeLayout(False)
        Me.tab_ativo.ResumeLayout(False)
        Me.tab_ativo.PerformLayout()
        Me.tab_passivo.ResumeLayout(False)
        Me.tab_passivo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents tab_cadastro As TabControl
    Friend WithEvents tab_ativo As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_cadastrar_ativo As Button
    Friend WithEvents txt_vtotal_ativo As TextBox
    Friend WithEvents txt_vunit_ativo As TextBox
    Friend WithEvents txt_qtd_ativo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_desc_ativo As TextBox
    Friend WithEvents txt_nome_ativo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_tipo_ativo As Label
    Friend WithEvents cmb_tipo_ativo As ComboBox
    Friend WithEvents cmb_categoria_ativo As ComboBox
    Friend WithEvents tab_passivo As TabPage
    Friend WithEvents cmb_categoria_passivo As ComboBox
    Friend WithEvents cmb_tipo_passivo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_cadastrar_passivo As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_vtotal_passivo As TextBox
    Friend WithEvents txt_vunit_passivo As TextBox
    Friend WithEvents txt_qtd_passivo As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_desc_passivo As TextBox
    Friend WithEvents txt_nome_passivo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_vtotal_ativo As Label
    Friend WithEvents lbl_vunit_ativo As Label
    Friend WithEvents lbl_vtotal_passivo As Label
    Friend WithEvents lbl_vunit_passivo As Label
    Friend WithEvents btn_voltar As Button
End Class
