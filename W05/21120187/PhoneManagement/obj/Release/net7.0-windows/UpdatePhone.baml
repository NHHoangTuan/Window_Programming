   M S B A M L   `   `   `  ���� J  FPhoneManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:PhoneManagementPhoneManagement  E'clr-namespace:PhoneManagement.ConverterPhoneManagement.Converter  !    PhoneManagement.UpdatePhone   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     /localclr-namespace:PhoneManagement     :local1'clr-namespace:PhoneManagement.Converter     c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   -     � Title$  UpdatePhone��$	��470��$	��350�� � 	Resources ;  5PhoneManagement.Converter.RelativeToAbsoluteConverter   absoluteConverter��%   &	          .��� .+��� .+��� $��0, 10, 0, 0q� �� Orientation$ Vertical=�.+��� $��20,0,0,0q�$��
Phone Name��$��14(�$��Medium"����#353935�� $
��Left=�$��1q����#fa5654 �� CornerRadius$ 5��
�������$��35��$	��270��$��20 10 10 10q�._�� $	��250��$��0q�$��Center=�.+��� -    ��Name$ NameTermTextBox��$��0q�$��Center=�$��13(�$	��270������ *Name+.����  J� IsHitTestVisible$ False��$��Center=�$��13(�$
��Left=�$��5,0,0,0q�
����������� *Update+����  �� 
TargetType" ��.���  �� Property � y� �� Value$ 	Collapsed=�	 �� Triggers	 �� 
 �� Binding
 �� *Text+ �� ElementName$ NameTermTextBox�� �� Value  .a���  � y�$ Visible=��� $��
0, 0, 0, 0q�$ Vertical=�.+��� $��20,0,0,0q�$��Price��$��14(�$��Medium"����#353935�� $
��Left=�$��1q����#fa5654$ 5��
�������$��35��$	��190��$��20 10 10 10q�._�� $	��170��$��0q�$��Center=�.+��� -   $ PriceTermTextBox��$��0q�$��Center=�$��13(�$	��190������ *Price+.���� $ False��$��Enter price��$��Center=�$��13(�$
��Left=�$��5,0,0,0q�
����������� " ��.���  � y�$ 	Collapsed=�	 �� 
 �� *Text+$ PriceTermTextBox��  .a���  � y�$ Visible=��� $��
0, 0, 0, 0q�$ Vertical=�.+��� $��20,0,0,0q�$��Manufacturer��$��14(�$��Medium"����#353935�� $
��Left=�$��1q����#fa5654$ 5��
�������$��35��$	��190��$��20 10 10 10q�._�� $	��170��$��0q�$��Center=�.+��� -   $ TradeMarkTermTextBox��$��0q�$��Center=�$��13(�$	��190������ *Manufacturer+.���� $ False��$��Enter manufacturer��$��Center=�$��13(�$��5,0,60,0q�
����������� " ��.���  � y�$ 	Collapsed=�	 �� 
 �� *Text+$ TradeMarkTermTextBox��  .a���  � y�$ Visible=��� $��0��.+��� $��
20,20,0,10q�$��Product Image��$��14(�$��Medium"����#353935�� $ 
Horizontal=�$��30, 0, 30,10q�.+��� -   $��UpdateImageButton��$	��Top=�$��10,0,0,0q�$��35��$��50��  MyButtonStyle#��[ .��.  (MahApps.Metro.IconPacks.PackIconMaterial  $��Center=�$��Center=�$��20��$��20�� �� BitmapScalingMode$ HighQuality=�   Kind$ Image=�
���  ���� -   $��updateImage��$	��Top=�$��
20, 0, 0,0q�$	��100��$	��100��$��Center=����� *	ImagePath+ �� 	Converter# [  �� -   $��SaveProduct��$��80��$��30��#��[ $	��0.5q�
���  ��$��Right=�$��0,2,20,0q�.���� $ 
Horizontal=�.+��� $��Medium"�
���  ��Save