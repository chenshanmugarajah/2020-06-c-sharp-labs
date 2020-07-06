function global:pushtogit {
    param (
        [string]$commitMsg,
        [string]$echoMsg
    )
    git add .
    git commit -m $commitMsg
    git push
    echo $echoMsg
}

pushtogit $commitMsg, $echoMsg