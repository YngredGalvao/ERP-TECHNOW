   M S B A M L   `   `   `  ????@  <Teste, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:TesteTeste  5   	       Teste.Caixa   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Teste     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullZ VMaterialDesignThemes.MahApps, Version=0.1.4.1513, Culture=neutral, PublicKeyToken=nullHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5   	   -   5          ? Title$  Teste??5   	   $	??600??6   $
??1080??6'    ? WindowStartupLocation$ CenterScreen=?67    ? 
ResizeMode$ NoResize=?6\    ? WindowStyle$
 None=?6r    ? WindowState$ 	Maximized=?6?   $??Roboto)?6?   $
??1179??6?   $	??585??6?   .??5	      ?  ? ColumnDefinitions 5   
   ?? 5      $	??776 ?6   ?? 5      .+?5   
   ? -   5         ?Name$ GridMenu??5      $	??166??6!   $
??Left=?6-   ???	#FF363636 J? Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 2Q?6#   	   ShadowDepth$	 1Q?62   .+?5      ?? .+?5      ?? -   5        
 ??Name$
 ListViewMenu??5      $??Disabled=?62   $	??543??6?   .@?5      ?? -   5         ??Name$ ItemSale??5   #   $??60??65   .??5      ??  ?? Orientation$ 
Horizontal=?6%   .+?5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Pencil=?66   $??25??6D   $??25??6P   $??10q?6[   ?? 5      $??Caixa??6(   $??Center=?65   5      5      ?? 5      -   5        $ 
ItemCreate??5   #   $??60??67   .??5      ?? $ 
Horizontal=?6%   .+?5        $ 
BoxVariant=?66   $??25??6H   $??25??6T   $??10q?6_   ?? 5      $??Produtos??6(   $??Center=?68   5       5!      ?? 5"      -   5        $ ItemProduct??5"   #   $??60??68   .??5#      ?? $ 
Horizontal=?6%   .+?5$        $ 
BoxVariant=?66   $??25??6H   $??25??6T   $??10q?6_   ?? 5%      $??Consultas Pdt??6(   $??Center=?6=   5&      5'      5(      5)      ? 5*      $??	0,541,0,0q?6   .+?5+      ?? -   5        $??59??5+      $??Bottom=?6X   .@?5,      ?? -   5        $ 
ItemLogout??5,   #   $??59??67   .??5-      ?? $ 
Horizontal=?6%   .+?5.        $ Logout=?66   $??25??6D   $??25??6P   $??10q?6[   ?? 5/      $
??SAIR??6(   $??Center=?64   $??28??6O   50      51      52      53      54      ? 56   
   $??	171,0,0,0q?6   .+?57      ?? -	   5        $??tbVenda??57   [   $??Center=?6    ?? TextAlignment$ Center=?66   $??25(?6M   $'??!Pressione F5 para iniciar a venda??6j   $	??Top=?6?   $??51??6?   $	??605??6?   ?? 59      
???????$??1q?6-   $??10,56,10,10q?6A    ?? CornerRadius$ 5??6V   ._?5:      &   System.Windows.Controls.DataGrid  -
   5          Name$ dgCaixa??5:      $??	0,-1,-1,0q?6,      AutoGenerateColumns .  $??Disabled=?6[      Columns 5;      0  *System.Windows.Controls.DataGridTextColumn  5<      ,  &System.Windows.Controls.DataGridColumn   Header$	 Cod??6-   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   ??  ?? Path$ 
codProduto?  5=      $ Produto??6-      MinWidth$	 150Q?6>    6M   ?? $ nomeProduto?  5>      $ 	Valor Und??6-    6@   ?? $ 
precoVenda?  5?      $ 
Quantidade??6-    6A   ?? $ 
quantidade?  5@      $ Total??6-    6<   ?? $ totalProdutoVenda?5B      5C      5E      ? 5F   
   $??1??6    ? RowDefinitions 5G      ?? 5H      $
??1.5* ?6    ?? 5I      $??3* ?6    ?? 5J      $??3* ?6    .+?5L      (  "MaterialDesignThemes.Wpf.ColorZone  $??5q?6'   .??5M      ?? $??Total da Venda??6   $??40(?61   $??Center=?6?   $??20q?6\   5N      ?? 5O      
???????$??1q?6-   $ 5??6A   $??1??6R   $??5q?6_   ._?5P      ? .+?5Q      ?? -   5         ??Name$ txtTotalVenda??5Q       $??Center=?67   $??Center=?6?   $ Center=?6?   $??50(?6?   $??	0,78,0,77q?6?   $	??383??6  ??6T   ?? *
totalVenda+ ?? Mode$ OneWay=? ?? UpdateSourceTrigger$ PropertyChanged=? ?? StringFormat$ F3??6  5R      5S      ? 5T      -   5        $ gridPdtAtual??5T   3   $??2??6   $??	10,10,5,0q?6    .+?5U      ?? -   5         ??Name$ txtPdt??5U       %  !MaterialDesignFloatingHintTextBox#??[  6*   {?.  $	??Top=?6w   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Produto??6?   $??
10,10,10,0q?6?   6?   ?? 5V      -   5        $ txtQtd??5V      #??[  6*   $	??Top=?6e   {?.  $	 Qtd??6?   $??	10,64,0,0q?6?   $
??Left=?6?   $	??140??6?   ?? 5W      -   5        $ txtValorUnd??5W      #??[  6/   {?.  $	??Top=?6|    ?? 
IsReadOnly . $ Valor??6?   $??	0,64,10,0q?6?   $??Right=?6?   $	??140??6?   ?? 5X      -   5        $??btnFinalizarVenda??5X   0   ???	#FF363636$??FINALIZAR VENDA??6I   $??
0,177,10,0q?6c   $	??163??6w   $??43??6?   $	??Top=?6?   $??Right=?6?   5Y      5Z      5[      5\      