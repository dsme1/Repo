<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width initial-scale=1.0">
        <title>PHP opdracht - vertaler</title>
    </head>
<body>
    <form method="post" action="">
    Naam: <input type="text" name="naam" placeholder="Uw naam" required /><br />
    Adres: <input type="text" name="adres" placeholder="Uw Adres" required /><br />
    Postcode: <input type="text" name="postcode" placeholder="Uw Postcode" required /><br />
    Plaats: <input type="text" name="plaats" placeholder="Uw Woonplaats" required /><br />
    Besteldatum: <input type="text" name="datum" placeholder="Datum" required /><br />
    Land:
        <select name="land">
        <option value="DEFAULT">Maak uw keuze</option>
        <option value="NL">Nederland</option>
        <option value="DE">Duitsland</option>
        <option value="EN">Engeland</option>
        <option value="FR">Frankrijk</option>
        <option value="SP">Spanje</option>
        <option value="IT">Italië</option>
        </select>
        <br />
        <input type="submit" name="submit" value="gegevens versturen" />
    </form>

<?php

if(isset($_POST["submit"]))
{
    $naam = $_POST["naam"];
    $land = $_POST["land"];
    
    switch ($land){
        case "DEFAULT":
            echo '<script>alert("Je moet een taal kiezen.")</script>';
            break;
        case "NL":
            echo "Goedemorgen " .$naam;
            break;
        case "DE":
            echo "Guten Morgen ".$naam;
            break;
        case "EN":
            echo "Good morning ".$naam;
            break;
        case "FR":
            echo "Bon nogwat ".$naam;
            break;
        case "SP":
            echo "Hablo voornaamwoord ".$naam;
            break;
        case "IT":
            echo "Salami ".$naam;
            break;
    }
}
?>
</body>
</html>