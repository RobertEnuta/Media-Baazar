<?php
require 'autoload/initialize.php';
?>
<!doctype html>
<html lang="en">
<link href="resources/MB.PNG" rel="icon" type="image/png" />
<body>
<?php    
    $requestedPage= 'loginpage.php';
    if (isset($_GET['page']))
     {
        switch ($_GET['page'])
         {
            case 'menu':
                if(isset($_SESSION['user']))
                {
                $requestedPage = 'menu.php';
                }
                break; 
               
            case 'profile':  
                if(isset($_SESSION['user']))
                {         
                    $requestedPage = 'profile.php';          
                }
                break;  
            case 'schedule':         
                    $requestedPage = 'schedule.php';
                break;

                case 'unavailable':         
                    $requestedPage = 'unavailable.php';
                break;

            case 'logout':    
                    $requestedPage = 'logout.php';
                break; 
        }
    }
    if (isset($requestedPage)) {
        require 'views/' . $requestedPage;
        }
        ?>
        <div class="page">
        </div>
        
    </body>
    </html>
    
