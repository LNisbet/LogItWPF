   M S B A M L   `   `   `  ????C  ?WpfLogIt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfLogItWpfLogIt  5   	       WpfLogIt.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WpfLogIt     5   	     ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)   .??5	      ?? -   5         ??Name$ MainSP??5	      .+?5
   
   ?? -   5        $??inputSP??5
   .    ?? Orientation$ 
Horizontal=?6   .+?5      ?? $
??idUI??6   ?? 5      -   5         ??Name$ idUITBox??5      $	??100??6C   ??6(   ??  ?? Path$
 IdUI?6C   ?? 5      $??dateUI??6   ?? 5      -   5        $ 
dateUITBox??5      $	??100??6G   ??6*   ?? $ DateUI?6G   ?? 5      $??unitUI??6   ?? 5      -   5        $ 
unitUITBox??5      $	??100??6G   ??6*   ?? $ UnitUI?6G   ?? 5      $??dataUI??6   ?? 5      -   5        $ 
dataUITBox??5      $	??100??6G   ??6*   ?? $ DataUI?6G   ?? 5      $??
commentsUI??6   ?? 5      -   5        $ commentsUITBox??5      $	??100??6O   ??6.   ?? $ 
CommentsUI?6O   5      ?? 5   
   -   5         ??Name$	 Add??5      $	??Add??6   6,   ?? 5   
   -	   5        $ Update??5      $??Update??6!   62   ?? 5   
   -
   5        $ Delete??5      $??Delete??6!   62   ?? 5   
   -   5        $
 TEST??5      $
??TEST??6   6.   ?? 5   
   -   5         ??Name$ DataListBox??5      $
??auto??6'   $	??300??64   $??Stretch=?6A   $??Visible=?6_   ??5      ?? 5      .R?5      ? $	??0,2q?6    ? ColumnDefinitions 5      ?? 5       $??50 ?6/   ?? 5!      $	??200 ?6/   .+?5#      ?? $??0??6$   $??20,0,0,0q?6H   $	??200??6Z   ??64   ?? *ID+6Z   ?? 5$      $??1??6$   $??20,0,0,0q?6J   $	??200??6\   ??64   ?? *Date+6\   ?? 5%      $??2??6$   $??20,0,0,0q?6J   $	??200??6\   ??64   ?? *Unit+6\   ?? 5&      $??3??6$   $??20,0,0,0q?6J   $	??200??6\   ??64   ?? *Data+6\   ?? 5'      $??4??6$   $??20,0,0,0q?6N   $	??200??6`   ??64   ?? *
Comments+6`   5)      5*      5-      5.      5/      