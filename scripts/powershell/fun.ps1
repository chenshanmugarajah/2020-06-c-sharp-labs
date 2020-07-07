function global:newMenu {
    C:\Users\Github\2020-06-c-sharp-labs\scripts\powershell
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
    $menuitems = Get-Content C:\Github\2020-06-c-sharp-labs\scripts\powershell\menu-items
    echo "" > fullmenu.txt
    foreach ($item in $menuitems) {
        echo $item >> fullmenu.txt
    }
}