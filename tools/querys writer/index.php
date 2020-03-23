<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
        label, input {
            display:block;
        }
        body {
            text-align:center;
        }
        input {
            margin-left:44%;
        }
        label {
            font-size: 180%;
        }
    </style>
</head>
<body>

    <?php
        if (isset($_POST['dbData'])) {
            $servername = $_POST['servername'];
            $username = $_POST['username'];
            $password = $_POST['password'];
            $dbname = $_POST['dbname'];
            
            // Create connection
            $conn = new mysqli($servername, $username, $password, $dbname);
           // Check connection
                if ($conn->connect_error) {
              die("Connection failed: " . $conn->connect_error);
                }
                echo "Connected successfully";
                $_SESSION['servername'] = $servername;
                $_SESSION['username'] = $username;
                $_SESSION['password'] = $password;
                $_SESSION['dbname'] = $dbname;
    
               

        } 
         if (isset($_SESSTION['servername'])) {
            $servername = $_SESSION['servername'];
            $username =    $_SESSION['username'];
            $password =  $_SESSION['password'] ;
            $dbname =  $_SESSION['dbname'];
            $conn = new mysqli($servername, $username, $password, $dbname);
           // Check connection
                if ($conn->connect_error) {
              die("Connection failed: " . $conn->connect_error);
                }
                echo "Connected successfully";

                $sql = "SHOW TABLES FROM $dbname";
$result = mysql_query($sql);

if (!$result) {
    echo "DB Error, could not list tables\n";
    echo 'MySQL Error: ' . mysql_error();
    exit;
}

while ($row = mysql_fetch_row($result)) {
    echo "Table: {$row[0]}\n";
}

mysql_free_result($result);
         } else  {
?>

<form method='POST' id='dbDataForm'>
    <h2> db data </h2>
    <label for=''>servername </label> 
        <input type='text' name='servername'>
        <label for=''>username </label> 
        <input type='text' name='username'>
        <label for=''>password </label> 
        <input type='text' name='password'>
        <label for=''>dbname </label> 
        <input type='text' name='dbname'>
        <input type='submit' name='dbData'>
    </form>


<?php
        }


            // example of connectionstring
           // $servername = "localhost";
           // $username = "root";
           // $password = "usbw";
           // $dbname = "kokenvoorgroepen";
            
            // Create connection
           // $conn = new mysqli($servername, $username, $password, $dbname);


    ?>
</body>
</html>