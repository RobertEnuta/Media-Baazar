<!DOCTYPE html>
<html lang="en">
<?php require 'autoload/initialize.php';?>
<head> 
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="resources/MB.PNG" rel="icon" type="image/png" />
    <link href="css/style-main.css"  rel = "stylesheet">
    <link href="css/footer.css"  rel = "stylesheet">
</head>
<title>Media Bazaar</title>
    <?php require 'views/topnav.php'; ?>
<body> 
  
<?php 
  if(isset($_SESSION['user']))
  {
    $employeeID= (int)$_SESSION['user'];
  }  
  $db = new UserAccess();
  $user = $db->GetEmployee($employeeID);
?> 
		<div class="container">
			<div class="contactus">	 
					<h1>Hello,Welcom to MediaBazaar!</h1> 
					<hr><p> This is a website created for the employees of Media Bazaar. 
                    <br>Here you can change your personal information,check your schedule and also select unavailable working days.</hr>
                    <div class="data">
            <label>Welcome,</label>
         <input type="name" value="<?php echo $user->getFirstname(); ?>" disabled >
      </div>
    </div>
    </div>
</body>
</html>