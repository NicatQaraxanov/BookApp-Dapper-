   M S B A M L   `   `   `  ����B  >WpfApp4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfApp4.ViewsWpfApp4.Views  5   	       WpfApp4.Views.MainView   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WpfApp4.Views     5   	     � Title$  
MainWindow��5   	   $	��600��6   $
��1080��6)    � WindowStyle$
 None=�66    � 
ResizeMode$ NoResize=�6I    � WindowStartupLocation$ CenterScreen=�6_    � 	Resources 5
         OpenMenu �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	CloseMenu��%|  &	        &	 4    �� 5   
   .��5      U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6,   $ 	rectangle��6�   .\�5        $ 0��6'   $ 0Q�63     5      $ 0:0:0.5��6'   $
 43.5Q�69   5      U� 5      $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6,   $ 
rectangle1��6�   .\�5        $ 0��6'   $ 0Q�63     5      $ 0:0:0.5��6'   $ -43.5Q�69   5      U� 5      $ (UIElement.Opacity)�6,   $ 
rectangle2��6\   .\�5        $ 0��6'   $ 1Q�63     5      $ 0:0:0.5��6'   $ 0Q�69   5      U� 5      $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $ 70Q�63     5      $ 0:0:0.5��6'   $	 200Q�69   5      5      �� 5   
   .��5      U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6,   $ 	rectangle��6�   .\�5        $ 0��6'   $
 43.5Q�63     5       $ 0:0:0.5��6'   $ 0Q�69   5!      U� 5"      $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6,   $ 
rectangle1��6�   .\�5#        $ 0��6'   $ -43.5Q�63     5$      $ 0:0:0.5��6'   $ 0Q�69   5%      U� 5&      $ (UIElement.Opacity)�6,   $ 
rectangle2��6\   .\�5'        $ 0��6'   $ 0Q�63     5(      $ 0:0:0.5��6'   $ 1Q�69   5)      U� 5*      $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5+        $ 0��6'   $	 200Q�63     5,      $ 0:0:0.5��6'   $ 70Q�69   5-      5.      51      .��54      � -   5        ���	#FF515151.+�55   
   � -   5        	 �Name$	 GridMenu��55      $
��Left=�6!   $��70��6<   ���	#FF116FA4
 K� ZIndex$
 1��6^   .+�56      �� .+�57      � $	��150��6   
�������6$   58      �� 59      -   5         ��Name$ 
ButtonMenu��59      $��Right=�6)   $	��Top=�6E   $��70��6�   $��70��6�   ��6]   Z� ��6s   Z� .��5:      � $��Center=�6   $��Center=�64   .+�5;      �� -   5         ��Name$ 	rectangle��5;       $��30��63   $��5��6>   $��0 0 0 0q�6I   ���	#FF515151$��Center=�6k   $	��Top=�6�    J� RenderTransformOrigin$ -0,0.5&�6�   z�5<      V� 5=      .~�5>   "   �� �� 5?   "   �� 5@   "   T� 5A   "   5B      5D      �� 5E      -   5        $ 
rectangle1��5E       $��30��64   $��5��6?   $��	0 20 0 0 q�6J   ���	#FF515151$��Center=�6n   $	��Top=�6�   $ -0,0.5&�6�   z�5F      V� 5G      .~�5H   "   �� �� 5I   "   �� 5J   "   T� 5K   "   5L      5N      �� 5O      -   5        $ 
rectangle2��5O       $��30��64   $��5��6?   $��0 10 0 0q�6J   ���	#FF515151$��Center=�6m   $	��Top=�6�   5P      5Q      �� 5S      $��Books��6   ��6%   �� *NavigateBookCommand+�� 5T      $��Students��6   $��0,321,0,247q�6T   ��6(   �� *NavigateStudentsCommand+6T   5V      �� 5X   
   -   5        $��Close��5X      $
��Left=�6!   $��
995,10,0,0q�6<   $	��Top=�6P   $��75��6h   6s   �� 5Z   
   -   5        $��DataG��5Z   �   $
��Left=�6?   $��
70,150,0,0q�6Z   $	��Top=�6n   $	��450��6�   $
��1010��6�   ��6   �� *SelectedViewModel+5\      5_      5a      