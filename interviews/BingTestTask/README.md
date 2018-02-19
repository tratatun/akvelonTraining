Given a comma-separated file and a column header write a method that will output all lines in the file that contain duplicate values in that column.

Implementation details and program interface is up to you to decide.
Examples:
TestFile.csv
column1,column2
1,a
1,b
1,c
2,d
3,d
4,d
4,e

run program with "TestFile.csv" and "column1" should find following lines as '1' and '4' occurred more than once in column1.
1,a
1,b
1,c
4,d
4,e

run program with "TestFile.csv" and "column2" should find following lines as 'd' occurred more than once in column2.
2,d
3,d
4,d
