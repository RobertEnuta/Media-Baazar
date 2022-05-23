<?php 
require '../autoload/initialize.php';

if(isset($_POST['ShiftType']) && isset($_POST['DayOfWeek']))
{  
    $shiftType= $_POST['ShiftType'];
    $dayOfWeek= $_POST['DayOfWeek'];
  
    if(isset($_SESSION['user']))
    {
        $user= (int)$_SESSION['user'];
    }
    $db = new UnavailableAccess();
    $unav = new Unavailable($user, $dayOfWeek, $shiftType);
    
    //echo $unav->getDayOfWeek();
   // echo $unav->getShiftType();

   $db->AddUnavailable($unav);
    header("location: ../index.php?page=unavailable");
    exit;
}
?>