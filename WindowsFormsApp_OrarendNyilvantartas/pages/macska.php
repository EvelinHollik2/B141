<div class="row">
    <?php
    foreach ($db->CicaTermek() as $row) {
        $image = null;
        if (file_exists("./Kepek/a_vasarlas/c/" . $row['ctermeknev'] . ".jpg")) {
            $image = "./Kepek/a_vasarlas/c/" . $row['ctermeknev'] . ".jpg";
        } else if (file_exists("./Kepek/a_vasarlas/c/" . $row['ctermeknev'] . ".jpeg")) {
            $image = "./Kepek/a_vasarlas/c/" . $row['ctermeknev'] . ".jpeg";
        } else if (file_exists("./kepek/" . $row['ctermeknev'] . ".png")) {
            $image = "./Kepek/a_vasarlas/c/" . $row['ctermeknev'] . ".png";
        } else if (file_exists("./Kepek/a_vasarlas/c/" . $row['ctermeknev'] . ".webp")) {
            $image = "./Kepek/a_vasarlas/c/" . $row['ctermeknev'] . ".webp";
        } else {
            $image = "./Kepek/a_vasarlas/noimg/noimage.jpg";
        }
        $card = '<div class="card" style="width: 18rem;">
                    <img src="'.$image.'" class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title">' . $row['ctermeknev'] . '</h5>' .
                '<p class="card-text">Darabszám: ' . $row['ctermekdarab'] . '</p>' .
                '<p class="card-text">Termék ára: ' . $row['ctermekar'] . '</p>   
                    <button><a href="index.php?menu=kosar">Kiválasztás</a></button>
                    </div>
                </div>
            ';
        
        echo $card;
    }
    ?>
</div>