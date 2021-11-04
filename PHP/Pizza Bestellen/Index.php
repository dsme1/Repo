<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width initial-scale=1.0">
        <title>PHP opdracht - vertaler</title>
    </head>
<body>
    <form id="bestelHoeveelheden" method="post" action="">
        <table>
            <tr>
                <th>Pizza</th>
                <th>Prijs</th>
            </tr>
            <tr>
                <td>Margherita</td>
                <td>12,50</td>
                <td><input type="number" name="pizza[margherita]"></td>
            </tr>
            <tr>
                <td>Funghi</td>
                <td>12,50</td>
                <td><input type="number" name="pizza[funghi]"></td>
            </tr>
            <tr>
                <td>Marina</td>
                <td>13,95</td>
                <td><input type="number" name="pizza[marina]"></td>
            </tr>
            <tr>
                <td>Hawai</td>
                <td>11,50</td>
                <td><input type="number" name="pizza[hawai]"></td>
            </tr>
            <tr>
                <td>Quattro Formagi</td>
                <td>14,50</td>
                <td><input type="number" name="pizza[quattro]"></td>
            </tr>
        </table>

    <br>
    Naam: <input type="text" name="naam" placeholder="Uw naam" required><br>
    Adres: <input type="text" name="adres" placeholder="Uw Adres" required><br>
    Postcode: <input type="text" name="postcode" placeholder="Uw Postcode" required><br>
    Plaats: <input type="text" name="plaats" placeholder="Uw Woonplaats" required><br>
    <br>    
    <input type="radio" id="afhalen" name="bezorghaal" value = "afhalen">
        <label for="bezorghaal">Afhalen</label>
    <input type="radio" id="bezorgen" name="bezorghaal" value = "bezorgen">
        <label for="bezorghaal">Bezorgen</label>
        <input type="date" id="bezorgdatum" name="bezorgdatum">
    <br>
        <input type="submit" name="submit" value="Bestellen">
    </form>

    <p>Bezorgkosten zijn 5 euro en worden verrekend bij bestellen</p>

<?php
if(isset($_POST["submit"]))
{
    var_dump($_POST);
    $naam = $_POST["naam"];
    $adres = $_POST["adres"];
    $postcode = $_POST["postcode"];
    $plaats = $_POST["plaats"];
    $datum = $_POST["bezorgdatum"];
    $pizzaPrijs = [];

    function bezorgkosten($pizzaPrijs)
    {
        $bezorgPrijs = array_sum($pizzaPrijs) + 5;
        return $bezorgPrijs;
    }

    function pizzaprijzenMaandag()
    {
        $pizzaPrijsMaandag = [];

        foreach ($_POST["pizza"] as $pizza)
        {
            array_push($pizzaPrijsMaandag, $pizza);
        }

        $totaalPrijs = array_sum($pizzaPrijsMaandag) * 7.50;

        return $totaalPrijs;
    }

    echo $naam;
    echo "<br>"; 
    echo $adres;
    echo "<br>";
    echo $postcode . " " . $plaats; 
    echo "<br>";
    echo "<br>";  

    foreach ($_POST["pizza"] as $key => $pizza)
    {
        switch ($key)
        {
            case "margherita":
                $pizzaTotaal = $pizza * 12.50;
                array_push($pizzaPrijs, $pizzaTotaal); 
                echo "Margherita: " . $pizza . " " . $pizzaTotaal;
                echo "<br>";                
                break;
            case "funghi":
                $pizzaTotaal = $pizza * 12.50;
                array_push($pizzaPrijs, $pizzaTotaal); 
                echo "Funghi: " . $pizza . " " . $pizzaTotaal;
                echo "<br>";   
                break;
            case "marina":
                $pizzaTotaal = $pizza * 13.95;
                array_push($pizzaPrijs, $pizzaTotaal); 
                echo "Marina: " . $pizza . " " . $pizzaTotaal;
                echo "<br>";   
                break;
            case "hawai":
                $pizzaTotaal = $pizza * 11.50;
                array_push($pizzaPrijs, $pizzaTotaal); 
                echo "Hawai: " . $pizza . " " . $pizzaTotaal;
                echo "<br>";   
                break;
            case "quattro":
                $pizzaTotaal = $pizza * 14.50;
                array_push($pizzaPrijs, $pizzaTotaal); 
                echo "Quattro Formagi: " . $pizza . " " . $pizzaTotaal;
                echo "<br>";   
                break;
        }
    }    
    
    echo "<br>";
    echo "Totaalprijs: " . array_sum($pizzaPrijs);
    echo "<br>";

    if ($_POST["bezorghaal"] == "bezorgen")
    {
        echo "Totaalprijs met bezorgkosten: " . bezorgkosten($pizzaPrijs);
    } 
    else 
    {
        echo "U kunt de pizza binnenkort ophalen";
    }

    if (date("l") == "Monday")
    {
        echo "<br>";
        echo pizzaprijzenMaandag();
    } 
    else if (date("l") == "Friday" && array_sum($pizzaPrijs) >= 20)
    {
        echo "<br>";
        $korting = array_sum($pizzaPrijs) * 15 / 100;
        echo array_sum($pizzaPrijs) - $korting;
    }
    
    echo "<br>";
    echo $datum . " " . date("l");
}
?>
</body>
</html>