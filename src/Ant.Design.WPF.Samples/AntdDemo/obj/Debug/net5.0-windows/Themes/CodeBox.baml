   M S B A M L   `   `   `  ����?  ;Antd, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;)clr-namespace:Antd.Controls;assembly=antdAntd.Controls  5      C ?AntdDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:AntdDemo.ControlsAntdDemo.Controls 5      9!clr-namespace:AntdDemo.ConvertersAntdDemo.Converters 5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   Ant.CodeSwitch  �� 
TargetType �� Property �� Value �� 
TargetType �� Padding �� Triggers P� Property P� Value  AntdDemo.Controls.CodeBox   Antd.Controls.Control � UseLayoutRounding	 � RowDefinitions
 J� SnapsToDevicePixels �� CornerRadius �� Path �� Mode �� RelativeSource �� ContentStringFormat    Title    TitleTemplate d�Name � ToolTip F�Name �� Stretch �� AncestorType    Description    DescriptionTemplate ��Name    Code    CodeTemplate �� Triggers P� 
SourceName �� 
TargetName �� Left
  �� Top! K� ZIndex" �� Padding# �� 
LineHeight3  -AntdDemo.Converters.StringToMarkDownConverter$   Instance% �� 	Converter/  )AntdDemo.Converters.StringToCodeConverter&   Instance�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     5      2Antd)clr-namespace:Antd.Controls;assembly=antd  5      ,Controlsclr-namespace:AntdDemo.Controls  5      0
Converters!clr-namespace:AntdDemo.Converters  5      %_  &	        '   �    7   �� 5      "  d�6#   .�5   
   ��  � �� �#0000006'   �� 5	   
    � ��
 ���� 6'   �� 5
   
    � ��$ 0q�6,   �� 5   
    �@J�Opacity$
 0.55Q�6$   �� 5   
    � �� 5      �� 5      " d�6"   .R�5      �� # z��6   #��z��5      #��z��5      #��z��5      ._�5      �� 5      5      5       5   
   P� 5       �@J�IsMouseOver$
 True��6-   . �5      ��  �@J�Opacity$ 1Q�6,   5      5      �� 5      "    6   .�5    
   ��  � ��$ Chinese Quote)�6'   �� 5!   
    � �� �#3146596'   �� 5"   
    � ��
 �����6'   �� 5#   
    � �� �#EBEDF06(   �� 5$   
    � ��$ 1q�6,   �� 5%   
    � ��$ 24 42 24 50q�6$   �� 5&   
    �@J�SnapsToDevicePixels$
 True��60   �� 5'   
    �@ CornerRadius$ 2��66   �� 5(   
    � �� 5)      �� 5*      "   6"   .R�5+      � $
 True��6   	 5,      �� 5.      $
��Auto �6,   �� 50      $
��Auto �6,   �� 52      $
��Auto �6,   �� 54      $
��Auto �6,   .+�57      �� $��0��6!   $��4��58   !   #��z��59   !   #��z��5:   !   #��z��5;   !   #
 z
 5<   !    5=   !   �� $! (Antd:Control.CornerRadius)�$ OneWay=� �� *TemplatedParent+�� 5?      #��z��6)   #��z��5@   )   #��z��5A   )   # z 5B   )   #��z��5C   )   �� 5E      $��1��6)   $|�False��5F   )   #��z 5G   )   #��z 5H   )   d� 5K      $ 
CodeSwitch��6'   $��2��5L   '   $��0 0 8 8q�5M   '   $ 	Show Code��5N   '   $��Bottom=�5O   '   $��Right=�5P   '   8��  .��5R      F� $ CodeSwitchPath��6#   $��16��5S   #   $��16��5T   #   $ Uniform=�5U   #   ������I�<e��Ӡ
;=)��d�<�2г<ފV�� �/o�T�� �/o�TӞe�.��E�I�,�&^#��+�#��+�#��+�e��*D]��9�* y����+�#�ѱ�5��ю��+��{'�c��*]��(%��*�Y*�\�+CQ�+Ӣ�,n�,^#�.�1�,���/+ѐq�;~�� Ӑ�O<�m ���<�� �I�<k����>&2{��x����< �CYTG���EI�х�EI�х�EI���7�W�g�h?�L;rN��L;rN��|����0@�P�-�&���?	|,�V��	�Q���@���	�@N����@�"�v�* @�<	 �㩢�z(@��f �|����1@�� � �J��+�K*w���,FFps�,��TF�+Ӄ�c=S*EVK_!�(��vu'��>&2{	��5V   #   �� $ 
Foreground� �� " d�5W   #   5X      �� 5Y      $��2��6)   $|�False��5Z   )   #��z 5[   )   #��z 5\   )   �� 5^      $
 Code��6)   $��3��5_   )   $|�False��5`   )   $y�	Collapsed=�5a   )   #��z 5b   )   #��z 5c   )   5d       5e      P� 5f      $ 
CodeSwitch��6"    �@d�	IsChecked$
 TrueY�6O   . �5g      �� $ 
CodeSwitch��6%    �@�ToolTip$ 	Hide Code��6P   �� 5h      $ CodeSwitchPath��6%    � ��� ���I�<e��Ӡ
;=)��d�<�2г<ފV�� �/o�TӞe�.��E�I�,�&^#��+�e��*D]��9�* y����+�#�ѱ�5��ю��+��{'�c��*]��(%��*�Y*�\�+CQ�+Ӣ�,n�,^#�.�1�,���/+ѐq�;~�� Ӑ�O<�m ���<�� �I�<k����>&2{��x����< �CYTG���EI���7�W�g�h?�L;rN��|����0@�P�-�&���?	|,�V��	�Q���@���	�@N����@�"�v�* @�<	 �㩢�z(@��f �|����1@�� � �J��+�K*w���,FFps�,��TF�+Ӄ�c=S*EVK_!�(��vu'��>&2{��v�&�d �ݒ2(G��q��(�	/
6l(&�ѣJ�{�R3�K�r���4ڥ�j��5~�R�5�#m��A~4�pH��2�ɜ��]1�]�#�$�	�]�#�$�	ӵ�#*:&Z:%�v�v�&�d 	6Q   �� 5i      $
 Code��6%    � y�$ Visible=�6M   5j      5l      5n      �� 5o   
    �@  TitleTemplate 5p      �� 5q      .R�5r      �� .+�5s      �� $ 0��6!   $  0��5t   !   $��0 1 0 0q�5u   !   ��5v   !   �� *ActualWidth+ �� "   ��5w   !   �� *BorderBrush+ �� "   �� 5x      $ 32��6$   $	  -10��5y   $   $! 1��5z   $   $	" 8 1q�5{   $   
�������$��Medium"�5}   $   #��z��5~   $   5      5�      5�      �� 5�   
    �@  DescriptionTemplate 5�      �� 5�      .R�5�      �� $��32 18q�6'   $# 28��5�   '   ��5�   '   �� *	Content+ �� *TemplatedParent+#% Z$ 5�      5�      �� 5�   
    �@  CodeTemplate 5�      �� 5�      .R�5�      �� $��0 1 0 0q�6   $ 32 16q�5�      ��5�      �� *ActualWidth+ �� "   ��5�      �� *BorderBrush+ �� "   ._�5�      �� ��6+   �� *	Content+ �� *TemplatedParent+#% Z& 5�      5�      5�      5�      5�      