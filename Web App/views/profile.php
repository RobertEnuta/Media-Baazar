<!DOCTYPE html>
<html lang="en">
<?php require 'autoload/initialize.php';?>
<head> 
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="resources/MB.PNG" rel="icon" type="image/png" />
    <link href="css/style-main.css"  rel = "stylesheet">
    <link href="css/nav.css"  rel = "stylesheet">
    <link href="css/footer.css"  rel = "stylesheet">
    <link href="css/profile.css"  rel = "stylesheet">
    </head>
    <!--title-->
<body>
<?php 
  if(isset($_SESSION['user']))
  {
    $employeeID= (int)$_SESSION['user'];
  }
  
  $db = new UserAccess();
  $user = $db->GetEmployee($employeeID);
?> 
<?php  require 'views/topnav.php'; ?>
<div id="page-container">
<div id="content-wrap">

<form action="handlers/profileHandler.php" method="post">
  <div class="user-box">
      <div class="cont">
      <div class="c-title">
          Profile
      </div>
      <img src="resources/man_male_avatar_portrait-512.png" alt="pic" width="150px" height ="150px" margin=left>
    
   
      <div class="data">
      <label>ID:</label>
      <input type="text" value="<?php echo $user->GetEmployeeID(); ?>"disabled>
      </div>
       

      <div class="data">
      <label>First Name:</label>
      <input type="text" value="<?php echo $user->getFirstname(); ?>"disabled>
      </div>
      

      <div class="data">
      <label>Last Name:</label>
      <input type="text" value="<?php echo $user->getSurname(); ?>"disabled>
      </div>
       
      <div class="data">
      <label>Date Of Birth:</label>
      <input type="text" value="<?php echo $user->getdateOfBirth(); ?>"disabled>
      </div>

      <div class="data">
      <label>BSN:</label>
      <input type="text" value="<?php echo $user->getBSN(); ?>"disabled>
      </div>

      <div class="data">
      <label>Email Address:</label>
      <input type="text" id="newemail" name="newemail" value="<?php echo $user->getEmail(); ?>" >
      </div>
      
      <div class="data">
      <label>Password:</label>
      <input type="password" id="newpassword" name="newpassword" value="<?php echo $user->getPassword(); ?>">
      </div>

      <div class="data">
      <label>Address:</label>
      <input type="text" id="newaddress" name="newaddress" value="<?php echo $user->getAddress(); ?>" >
      </div>

      <div class="data">
      <label>Phone Number:</label>
      <input type="text" id="newphonenumber" name="newphonenumber" value="<?php echo $user->getPhoneNumber(); ?>">
      </div>
      
    <div class="btn1">
    <a href="#"> 
      <button type="submit"><span> Confirm Changes </span></button>
        </div>
    </a>
    </div>  
    </div>
    </form>
</body>
</div>
    <?php require 'views/footer.php';?> 
</div>
</html>
