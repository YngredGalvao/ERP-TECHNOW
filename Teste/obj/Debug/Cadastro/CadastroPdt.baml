   M S B A M L   `   `   `  ????@  <Teste, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:TesteTeste  5   	       Teste.CadastroPdt   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullZ VMaterialDesignThemes.MahApps, Version=0.1.4.1513, Culture=neutral, PublicKeyToken=nullHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5   	   !localclr-namespace:Teste   5   	   -   5          ? Title$  Cadastro??5	   	   $??445.41??6   $	??838??6*    ? WindowStartupLocation$ CenterScreen=?66    ? 
ResizeMode$ NoResize=?6[   .??5
      ? ???	#FFDADADA.+?5   
   ?? $??
10,10,10,0q?6   $	??400??6%   
???????$	??Top=?6G    ?? Padding$ 30q?6_    ?? CornerRadius$ 10??6l   $	??800??6~   $	??390??6?    J? Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q?6#      Color$ 	LightGray??63      ShadowDepth$ 0Q?6E   ._?5      ?? $??	0,0,0,-20q?6   .+?5      ?? $??Cadastro de produtos??6   $??30(?68   $
??Bold"?6F   $??0 0 0 20q?6X   ? 5      $??0 0 0 20q?6   $	??284??6)   .+?5      ?? -   5        	 ??Name$	 
txtProduto??5      )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Produto??62    %  !MaterialDesignFloatingHintTextBox#??[  6[   $??0,10,0,0q?6?   $??43??6?   $	??Top=?6?   ?? 5      -   5        $	 txtCodBarras??5      $
 Código de barras??64   #??[  6f   $??0,62,0,0q?6?   $??44??6?   $	??Top=?6?   ?? 5      -   5        $	 txtVenda??5      $
 Preço de venda??60   #??[  6`   $??0,116,390,0q?6?   $??42??6?   $	??Top=?6?   ?? 5      -   5        $	 txtCusto??5      $
 Preço de custo??60   #??[  6`   $??400,116,0,0q?6?   $??43??6?   $	??Top=?6?   ?? 5      -   5         ??Name$ cbGrupo??5      $
 Grupo??60   $??0,178,390,0q?6W   $	??Top=?6l   $??42??6?    ?? DisplayMemberPath$
 nome??6?    ?? SelectedValuePath$	 cod??6?   ??6?   ?? *produto_grupo+6?   ?? 5      -   5         ??Name$ cbxAtivo??5      $??Ativo??61   $??400,178,276,0q?6A   $??43??6X   $	??Top=?6d   -  'MaterialDesignThemes.Wpf.CheckBoxAssist   CheckBoxSize$ 20Q?6|   ?? 5      -   5        ???	#FF363636$??	Cadastrar??5   4   $??586,248,0,0q?6H   $??32??6]   $	??Top=?6i   6?   ?? 5       -	   5        ???	#FF363636$??Cancelar??5    4   $??400,248,186,0q?6G   $??32??6^   $	??Top=?6j   6?   ?? 5!      -
   5        $
??cbUn??5!      $
??Left=?6+   $??554,178,0,0q?6F   $
 Unidade de medida??6[   $??42??6?   $	??Top=?6?   $	??176??6?   .@?5"      ?? $??KG??6'   
 ? Tag$ KG??64   ?? 5#      $??UN??6'   $ UN??64   ?? 5$      $??L??6'   $ L??63   5%      5&      5'      5(      5)      5*      