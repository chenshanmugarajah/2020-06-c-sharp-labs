echo 'Hello this is an amazing script'
md FolderA
cd FolderA
echo "Line01" >> file01.txt
echo "Line02" >> file01.txt
echo "Line03" >> file01.txt
echo 'Line03\nLine04' >> file01.txt
copy file01.txt file02.txt
type file01.txt