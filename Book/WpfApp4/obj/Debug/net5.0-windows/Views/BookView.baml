   M S B A M L   `   `   `  ����B  >WpfApp4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfApp4.ViewsWpfApp4.Views  5          WpfApp4.Views.BookView   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:WpfApp4.Views     5      .��5	      � 
�������.+�5   
   �� $��+��6   $
��Left=�6   $��	10,10,0,0q�68   $	��Top=�6K   $��41��6c   ��6n   �� *NavigateAddBook+�� 5   
   $
��Left=�6\   $��32��6w   $��	73,10,0,0q�6�     �� TextWrapping$
  Wrap=�6�   $	��Top=�6�   $	��172��6�    J� RenderTransformOrigin$ 0.319,0.034&�6�   4  .System.Windows.Automation.AutomationProperties   HelpText$ Search��6�   ��6   �� *Search+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�6�   �� 5   
   -   5        $	��Get��5      $��Get Book From Student��6   $��589,20,10,398q�6_   ��6<   �� *GetBookCommand+6_   &   System.Windows.Controls.DataGrid  5   
   $��False��6   $��0,62,0,0q�69      AutoGenerateColumns$ False��6�      
IsReadOnly$
 True��6�   ��6K   �� *Books+$ PropertyChanged=�$ TwoWay=� �� SelectedItem 6�   �� *SelectedBook+$ PropertyChanged=�$ TwoWay=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 	Book Name��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 68   �� *Name+  5      $	 Count��6%   
 64   �� *
Quantity+4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6)   .+�5   "   �� ��6+   �� *
Students+ 6L   ��  �� RelativeSource ��  �� AncestorType" >� �� Mode$ FindAncestor=� �� Path$! DataContext.SelectedStudent�5      5         HeaderTemplate 5!      �� 5"      .R�5#      �� $��Students��6(   5$      5'      5+      5-      5.      