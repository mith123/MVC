<?php
$con=mysqli_connect("localhost","root","","new");

	if(isset($_POST['create']))
	{
		
		$a=$_POST['name'];
	    $b=$_POST['password'];
		$c=$_POST['email'];
		$sql="insert into log(name,password,email)values('$a','$b','$c')";
		$res=mysqli_query($con,$sql);
			
	}
	if(isset($_POST['login']))
	{
		$a=$_POST['name'];
		$b=$_POST['password'];
		$sql="select * from log where name='$a' and password='$b'";
		$res=mysqli_query($con,$sql);
		header("location:home.php");
		
	}
	?>


<!DOCTYPE html>
<html lang="en" >

<head>
  <meta charset="UTF-8">
  <title>login</title>
  
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/meyer-reset/2.0/reset.min.css">

  <link rel='stylesheet' href='https://fonts.googleapis.com/css?family=Roboto:400,100,300,500,700,900'>
<link rel='stylesheet' href='https://fonts.googleapis.com/css?family=Montserrat:400,700'>
<link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css'>

      <link rel="stylesheet" href="css/style.css">

  
</head>

<body>
  

  
<div class="container">
  <div class="info">
    <h1> Login Form</h1><span>login <i class="fa fa-heart"></i> here <a href="http://andytran.me"></span>
  </div>
</div>
<div class="form">
  <div class="thumbnail"><img src="https://s3-us-west-2.amazonaws.com/s.cdpn.io/169963/hat.svg"/></div>
  <form class="register-form" action="#" method="post">
    <input type="text" name="name" placeholder="name"/>
    <input type="password" name="password" placeholder="password"/>
    <input type="text" name="email" placeholder="email"/>
   <input type="submit" name="create" value="create" />
    <p class="message">Already registered? <a href="#">Sign In</a></p>
  </form>
  
  <form class="login-form" action="#" method="post">
    <input type="text" placeholder="username" name="name"/>
    <input type="password" placeholder="password" name="password"/>
	  <input type="submit" name="login" value="login" />
    <p class="message">Not registered? <a href="#">Create an account</a></p>
  </form>

</div>
<video id="video" autoplay loop poster="polina.jpg">
  <source src="http://andytran.me/A%20peaceful%20nature%20timelapse%20video.mp4" type="video/mp4"/>
</video>
  <script src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>

  

    <script  src="js/index.js"></script>
    



</body>

</html>
