   M S B A M L   `   `   `  ����A  =Course, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:CourseCourse  5          Course.RoomsList   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:Course     5        N� 
Background
  ��d� N� Title$ 	RoomsList��5	      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� -   5         ��Name$ RoomsListView��5      $��290,10,290,10q�6*   $	��200��6A   $��2��6M    �� View 5      �� 5      .P�5      �� $%��Список аудиторий��6%    �� Width$	 180��6g    �� DisplayMemberBinding 6?   �� *number+6g   5      5      �� 5   
   -   5         ��Name$ newRoom��5      $��2��6#   $	��200��60   $��0,0,0,0q�6<   �� 5   
   $��3��6    �� Orientation$ 
Horizontal=�6"   $��	0,10,0,10q�6;   $��Center=�6N   .+�5      �� -   5        $��Добавить��5      $��0,0,15,0q�68   �� 5      -   5        $��Удалить��5      6'   5      �� 5    
   -   5        $��3��5       $��
Назад��6   $��Right=�6.   6J   5!      5"      