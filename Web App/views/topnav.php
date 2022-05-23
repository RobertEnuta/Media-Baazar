<!DOCTYPE html>
<html lang="en">
<head> 
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="css/style.css"  rel = "stylesheet">
    <link href="resources/MB.PNG" rel="icon" type="image/png" />
    <link href="css/nav.css"  rel = "stylesheet">

    <title> MediaBazzar</title>
    <body> 
      <div class="header">    
        <h1 class="glow">Media Bazaar</h1>  
      </div>

      <div class="topnav">
        <?php if (isset($_SESSION['user'])) : ?>
        <a href="index.php?page=menu" class="menu">Home</a>
        <a href="index.php?page=schedule" class="schedule">Schedule</a>
        <a href="index.php?page=unavailable" class="unavailable">Unavailable</a>
        <a href="index.php?page=logout" class="right">Log out</a>  
        <a href="index.php?page=profile" class="right">Profile</a>
       

        <?php  else : ?>
        <a href="index.php"></a>
        <?php endif; ?>         
    </div>
</head>
<script src="JS/topnav.js"></script>
</body>
</html>