   M S B A M L   `   `   `  ����L  HSyntraCalc.UI.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:SyntraCalc.UI.WPF.Views.PagesSyntraCalc.UI.WPF.Views.Pages  5      K*clr-namespace:SyntraCalc.UI.WPF.ConvertersSyntraCalc.UI.WPF.Converters  5      -    'SyntraCalc.UI.WPF.Views.Pages.Dashboard   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:SyntraCalc.UI.WPF.Views.Pages     5      A
converters*clr-namespace:SyntraCalc.UI.WPF.Converters     5        N� 
FontFamily$  Century Gothic)�5
       N� Title$ 	Dashboard��5       � DataContext 5      �� *
Dasboard+   Locator �� Source# [   � 	Resources 5      ?   9SyntraCalc.UI.WPF.Converters.StringToImageSourceConverter   StringToImageSourceConverter<   6SyntraCalc.UI.WPF.Converters.StringToPagePathConverter  StringToPagePathConverter��%:   &	       &	        5   
   62     5   
   6/   5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��3* �6    � RowDefinitions 5   
   �� 5      $��1* �6   .+�5"   
   �� $��0��5#      $��0��5$      ���#f2f2f2$��0 0 5 0q�5&      �� 5(   
   $��0��5)      $��0��5*       �� Orientation$ Vertical=�5+      $��20 20 25 20q�5,      .+�5.      ��  �� TextAlignment$ Center=�5/      $��CHOOSE YOUR SHAPE��50      �� 52      $��0��53      $��0��54      
������ $��10q�56      $��Center=�57      $��0q�58      ��59      �� *GeometricShapes+	 �� SelectedItem	 5:      �� *SelectedShape+��5<      �� 5=      .R�5>      �� $��5,0,0,5q�5?      $��Center=�5@      .+�5B      �� 
���   �$��10(�5D   !   ��5E   !   �� *	ShapeName+5G      5H      5J      5M      � 5R   
   $��1��5S      $��0��5T      $��20q�5U       5W      �� 5X      $��1* �6#   �� 5Y      $��1* �6#    5\      �� 5]      $��1* �6    .+�5b      �� $��0��5c      $��0��5d      $��	0 0 15 0 q�5e      $ Vertical=�5f      .+�5i      �� $��	25 0 25 0q�5j      ��5k      �� *SelectedShape.ShapeName+
 �� 	Converter#
 [ �� 5m      $
��Wrap=�5o      $ Justify=�5p      ��5n      �� *SelectedShape.Description+5p      5r       � 5v      $��1��5w      $��0��5x        � Source 5y      �� *ShapeControls+#
 [ 5z      5      5�      