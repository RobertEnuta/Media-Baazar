<?php 
require '../autoload/initialize.php';

if(isset($_POST['newemail']) && isset($_POST['newpassword']) && isset($_POST['newaddress']) && isset($_POST['newphonenumber']))
{  
    $emailAddress= $_POST['newemail'];
    $password= $_POST['newpassword'];
    $address= $_POST['newaddress'];
    $phoneNumber= $_POST['newphonenumber'];

    
    if(isset($_SESSION['user']))
    {
        $userID= (int)$_SESSION['user'];
    }
    $db = new UserAccess();
    $user = $db->GetEmployee($userID);
    $user->setEmail($emailAddress);
    $user->setPassword($password);
    $user->setAddress($address);
    $user->setPhoneNumber($phoneNumber);

    $db->UpdateUser($user, $userID);
    header("location: ../index.php?page=profile");
    exit;
}
?>