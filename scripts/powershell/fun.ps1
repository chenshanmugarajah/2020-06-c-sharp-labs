function global:newMenu {
    mkdir menu-items
    cd menu-items
}

function global:createItem {
    $menuItem = $args[0]
    $price = $args[1]

    echo $price >> $menuItem 
}

createItem $args[0] $args[1]

function global:collateMenu {
    $menuitems = Get-Content C:\Users\
    foreach ($item in $menuitems) {
        echo $item >> fullmenu.txt
    }
}