   M S B A M L   `   `   `  ????D  @SampleWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:SampleWPF.DataGridsSampleWPF.DataGrids  5   	   ,    &SampleWPF.DataGrids.DataGridRowDetails   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:SampleWPF.DataGrids     5   	     ? Title$  DataGridRowDetails??5   	   $	??500??6$   $	??500??61   .??5	      ? .+?5
   
   &   System.Windows.Controls.DataGrid  -   5        $??dgSamp??5
         AutoGenerateColumns$ False??6!      RowDetailsVisibilityMode$ VisibleWhenSelected=?6=      
IsReadOnly$
 True??6l      CanUserAddRows$ False??6~      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name??6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   ?? *Name+   RowDetailsTemplate 5      ?? 5      .R?5      ?? 
????·?$??1q?63   ._?5      ? 	 ? Orientation$	 
Horizontal=?6$   .+?5      ?? $??50??6=   $??50??6I   $??UniformToFill=?6T   $??0,0,5,0q?6l   ??6$   ?? *Image+6l   ?? 5      
 ?? Orientation$
 Vertical=?6)   .+?5   "   ?? $
 
Horizontal=?6-   .+?5   &   ?? $
??Bold"?60   $??8(?6B   $??Name: ??6O   ?? 5   &   $
??Bold"?60   $??Italic$?6B   ??6U   ?? *Name+5   #   ?? 5   "   $
 
Horizontal=?6-   .+?5   &   ?? $
??Bold"?60   $??8(?6B   $??	Element: ??6O   ?? 5   &   $??15??6L   $??15??6X   $??UniformToFill=?6c   $??0,0,5,0q?6{   ??6,   ?? *Element.Icon+6{   ?? 5   &   $
??Bold"?60   $??Italic$?6B   ??6U   ?? *Element.Color+??6z   ?? *Element.Name+5   #   5      5      5       5!      5#      5$      5%      