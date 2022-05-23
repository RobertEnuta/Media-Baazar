<?php
require '../autoload/initialize.php';

if (isset($_POST['password']) && isset($_POST['email'])) {

    $password = $_POST['password'];
    $emailAddress = $_POST['email'];
    $db = new UserAccess();
    if ($db->CheckUserLogin($emailAddress, $password) == 1) 
    {
        $_SESSION['logged'] = "Successful login";
        $_SESSION['user'] = $db->GetEmployeeID($emailAddress, $password);    
        $_SESSION['loginmessage']= 0;  
        $message = "Welcome, User";
        header("location: ../index.php?message=$message"); 
        echo "wow";
    }  
    else 
    {
        $message = "Invalid credentials";
        header("location: ../index.php?message=$message");
        echo "lol";
    }
}
?>