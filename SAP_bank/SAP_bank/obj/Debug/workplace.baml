   M S B A M L   `   `   `  ����C  ?SAP_bank, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:SAP_bankSAP_bank  5   	   =#clr-namespace:SAP_bank.userControlsSAP_bank.userControls  5   	       SAP_bank.workplace   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:SAP_bank     5   	   5users#clr-namespace:SAP_bank.userControls     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  	workplace��5
   	   $	��600��6   $
��1080��6(    � 
ResizeMode$ NoResize=�65    � WindowStartupLocation$ CenterScreen=�6K    � WindowStyle$
 None=�6p   
�������$��Century Gothic)�6�    � 	Resources 5         MenuOpen �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	MenuClose��%�  &	        &	 �     �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $ 60Q�63   6@     5      $ 0:0:0.5��6'   $	 200Q�69   6G   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $	 200Q�63   6A     5      $ 0:0:0.5��6'   $ 60Q�69   6F   5      5      5      	 � Triggers	 5      :� 5   
   
 :� RoutedEvent$
 ButtonBase.Click��6    :� 
SourceName$ ButtonOpenMenu��66   .[�5      �� #��[  6   6G   5      :� 5   
   $
 ButtonBase.Click��6   $ ButtonCloseMenu��66   .[�5      �� #��[ 6   6H   5       .��5#      � ���#f1fcfb � RowDefinitions 5$   
   �� 5%      $��70 �6   6*   �� 5&      $��* �6   6)    � ColumnDefinitions 5(   
   �� 5)      $	��200 �6   6-   �� 5*      $��* �6   6+   .+�5,   
   � $��0��6   $��0��6   $��2��6,   $��70��6@   ���#6795A0$	��Top=�6a   .+�5-      �� -   5        $��
HeaderWork��5-      $��SAPbank��6+   $��Center=�6:   $��Center=�6W   $��24(�6r   6�   �� 5/      $��Center=�6    �� Orientation$ 
Horizontal=�64   $��Right=�6M   .+�50      �� $
��lala��6   $��Center=�6(   $��18(�6C   6S   '  !MaterialDesignThemes.Wpf.PopupBox  51      $��10q�6+      PlacementMode$ BottomAndAlignRightEdges=�67      	StaysOpen .     PopupContent. 52      �� $	��160��6!   .+�53      �� -   5        $��14(�53   !   $��Мой профиль��6/   6e   �� 54      -   5        $$��MyProfileButton_ChangePassword��54   !   $��14(�6G   $#��Изменить пароль��6U   6�   �� 55      �� 56      -   5         ��Name$ ButtonPopUpLogout��56   /   $��14(�6!   $��
Выход��6J   6|   57      58      59      5:      � 5;   
   -   5         �Name$ GridMenu��5;   =   $��0��6   $��0��6   $��2��6,   $��60��6O   $
��Left=�6Z   ���#375A63.+�5=      �� .+�5>      � $	��150��6   
�������.+�5?      �� -   5        $ ButtonCloseMenu��5?      $��60��66   $��60��6A   $	��top=�6{   $��Right=�6�   $y�	Collapsed=�6�   ��6M   Z� ��6c   Z� .��5@      '  !MaterialDesignThemes.Wpf.PackIcon  ���#186059�  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ 	ArrowLeft=�6G   $��25��6X   $��25��6c   5A      �� 5B      -   5        $ ButtonOpenMenu��5B      $��60��65   $��60��6@   $	��top=�6z   $��Right=�6�   ��6L   Z� ��6b   Z� .��5C        ���#186059$
 Menu=�6G   $��25��6S   $��25��6^   5D      5E      �� 5F      $ 
Horizontal=�6   .+�5G        $ Person=�6.   $��25��6<   $��25��6G   $��15q�6S   $��Center=�6_   6|   �� 5H      -   5        $ MyProfileButton��5H      
�������$$��Мой профиль         ��6g   $��Century Gothic)�6�    $  MaterialDesignRaisedAccentButton#��[ 6�   +  %MaterialDesignThemes.Wpf.RippleAssist   Feedback �#6795A0��6�   Z� ��6�   Z� 6;  5I      �� 5J      $ 
Horizontal=�6   .+�5K        $
 Cash=�6.   $��25��6:   $��25��6E   $��15q�6R   $��Center=�6^   6{   �� 5L      -	   5        $ MyBalanceButton��5L      $'��!Мой баланс              ��6T   $��Century Gothic)�6w   
�������#��[ 6�    �#6795A0��6�   Z� ��6�   Z� 6>  5M      �� 5N      $ 
Horizontal=�6   .+�5O        $ History=�6.   $��25��6=   $��25��6H   $��15q�6T   $��Center=�6a   6~   �� 5P      -
   5        $ MyHistoryButton��5P      $&�� Моя история           ��6T   
�������$��Century Gothic)�6�   #��[ 6�    �#6795A0��6�   Z� ��6�   Z� 6=  5Q      �� 5R      $ 
Horizontal=�6   .+�5S        $ Transfer=�6.   $��25��6>   $��25��6I   $��15q�6V   $��Center=�6c   6�   �� 5T      -   5        $ TransferButton��5T      $#��Перевод средств��6S   
�������$��Century Gothic)�6�   #��[ 6�    �#6795A0��6�   Z� ��6�   Z� 65  5U      �� 5V      $ 
Horizontal=�6   .+�5W        $
 Bank=�6.   $��25��6:   $��25��6E   $��15q�6R   $��Center=�6_   6|   �� 5X      -   5        $ DepositButton��5X      $$��Депозит                ��6Q   
�������$��Century Gothic)�6�   #��[ 6�    �#6795A0��6�   Z� ��6�   Z� 6;  5Y      �� 5Z      $ 
Horizontal=�6   .+�5[        $ SquareIncCash=�6.   $��22��6C   $��22��6N   $��15q�6[   $��Center=�6h   6�   �� 5\      -   5        $ ConverterButton��5\      $*��$Конвертер валют       ��6T   
�������$��Century Gothic)�6�   #��[ 6�    �#6795A0��6�   Z� ��6�   Z� 6>  5]      5^      5_      %   SAP_bank.userControls.Converter  5`   
   -   5          Name$ ucConverter��5`      $��1��6/   $��1��6<   $y�Hidden=�6L   6b   #   SAP_bank.userControls.Deposit  5a   
   -   5          Name$ 	ucDeposit��5a      $��1��6+   $��1��68   $y�Hidden=�6H   6^   %   SAP_bank.userControls.MyBalance  5b   
   -   5          Name$ ucMyBalance��5b      $��1��60   $��1��6=   $y�Hidden=�6M   6c   %	   SAP_bank.userControls.MyHistory	  5c   
   -   5         	 Name$ ucMyHistory��5c      $��1��6/   $��1��6<   $y�Hidden=�6L   6b   %
   SAP_bank.userControls.MyProfile
  5d   
   -   5         
 Name$ ucMyProfile��5d      $��1��6/   $��1��6<   $y�Hidden=�6L   6b   $   SAP_bank.userControls.Transfer  5e   
   -   5          Name$ 
ucTransfer��5e      $��1��6-   $��1��6:   $y�Hidden=�6J   6`   *   $SAP_bank.userControls.ChangePassword  5f   
   -   5          Name$ ucChangePassword��5f      $��1��6:   $��1��6G   $y�Hidden=�6W   6m   5g      5h      