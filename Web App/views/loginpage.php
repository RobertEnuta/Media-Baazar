<!DOCTYPE html>
<html lang="en">
<?php require 'autoload/initialize.php';?>
<head> 
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="resources/MB.PNG" rel="icon" type="image/png" />
    <link href="css/style-main.css"  rel = "stylesheet">
    <title>Media Bazaar</title>
    </head>
<body>
<div id="page-container">
<div id="content-wrap">
<div class="header">      
        <h1 class="glow">Media Bazaar</h1>      
      </div>
      <?php
  $db = new UserAccess();

  if(isset($_SESSION['user']) && $_SESSION['loginmessage']==0)
  {
        $employeeID= (int)$_SESSION['user'];
        $user = $db->GetEmployee($employeeID);
        $userfirstname= $user->getFirstname();
        $_SESSION['loginmessage'] = 1;
       
        header("Location:index.php?page=menu"); 
        exit;
        $alert="<script>alert('Successfully logged in $adminfirstname');</script>";
        echo $alert;
   
    }?>
 <!--login-->
<div class ="bg-modal">
  <div class="modal-content">
    <div class="title">Login</div>
    <div class="user">
    <img src="resources/man_male_avatar_portrait-512.png" alt="pic" width="150px" height ="150px"></div>
    <form action="handlers/loginHandler.php" method="post">
    <form action="a" method="post">
        <div class="data">
          <label>Email Address:</label>
          <input type="text" placeholder="Email Address"  id="email" name="email" required>
        </div>
        <div class="data">
          <label>Password:</label>
        <input type="password" value="password" id="input" placeholder="Password" id="password" name="password" required><br><br>    
        </div>
<div class="forgot-pass">
<a href="#">Forgot Password?Contact your administartor!</a></div>
<div class="btn">
<div class="inner">
</div>
<button type="submit" >Login</button>
</form>
</form>
</div>
</div>
</body>
</html>