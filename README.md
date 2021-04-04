Console Application<br>
Lab: Functional Programming
# FilterByAge
Write a program that receives an integer __N__ on first line. On the next __N__ lines, read pairs of "__[name], [age]__". Then read three lines with:
- __Condition__ - "__younger__" or "__older__"
- __Age__ - Integer
- __Format__ - "__name__", "__age__" or "__name age__"
Depending on the __condition__, print the correct __pairs__ in the correct __format__. __Don’t use the built-in functionality from .NET. Create your own methods.__
## Examples
Input|Output|Input|Output|Input|Output
-----|------|-----|------|-----|------
5<br>Lucas, 20<br>Tomas, 18<br>Mia, 29<br>Noah, 31<br>Simo, 16<br>older<br>20<br>name age|Lucas - 20<br>Mia - 29<br>Noah - 31|5<br>Lucas, 20<br>Tomas, 18<br>Mia, 29<br>Noah, 31<br>Simo, 16<br>younger<br>20<br>name|Tomas<br>Simo|5<br>Lucas, 20<br>Tomas, 18<br>Mia, 29<br>Noah, 31<br>Simo, 16<br>younger<br>50<br>age|20<br>18<br>29<br>31<br>16
