function pushtogit {
    # param (
    #     OptionalParameters
    # )
    git add .
    git commit -m $args[0]
    git push
}

pushtogit $args[0]