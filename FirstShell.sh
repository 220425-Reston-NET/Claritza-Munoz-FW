# This is a comment
# Echo is a way to give feedback to the person running the shell script
echo "This is your first shell script!"

#variable
msg="Hello World Variable"
echo $msg # $ syntax is what we write to specify that we are referencing a variable

# control flow
# a way to tell the program to run multiple linees of code multiple times
# or run lines of code if a condition is met

# if statements
ten=10
five=5
thirteen=13

echo "===First If==="
if [ "$ten" -ge "$five" ]
then 
echo "Greater!"
echo "$ten > $five"
fi

if  [ "$five" -ge "$ten" ]
then
echo "Greater!"
fi 

echo "This is outside the then fi"

echo "===Second If==="
if [ "$five" -ge "$ten" ]
then
echo "Greater!"
echo "$five > $ten"
elif [ "$five" -le "$ten" ]
then
echo "Lesser!"
echo "$five < $ten"
fi

echo "===Third If==="
if [ "$five" -ge "$ten" ]
then
echo "Greater!"
echo "$five > $ten"
elif [ "$five" -ge "$thirteen" ]
then 
echo "Greater!"
echo "$five > $thriteen"
else
echo "Nothing matches"
fi


# Loop Statement
# a way to repeat multiple lines of code x amount of times

# For Loop
# Useful if we know how many times to execute lines of code

echo "===For Loop==="
echo "===First Loop==="
for number in 10 5 world 1 2
do
echo "Hello $number"
echo "Test"
done 


echo "===Second Loop==="
for i in {1..10}
do 
echo "$i"
done

echo "===While Loop==="
# if you dont know how many times you need to execute  those lines of code

while [ "$five" -le "$ten" ]
do
echo "Lesser!"
five=$(($five+1)) # $((mathematical operation))
echo "$five"
done

# Input and Output
# ask for input from user and output response

echo "What is your name?"
#read name #read name will store input in variable
echo "Hello $name, Welcome  to programming!"

# using a shell menu
clear # clear all text in terminal
repeat="true"

while [ "$repeat" == "true" ]
do
echo "Welcome to shell scripting!"
echo "What do you want to do today?"
echo " Enter 1 for adding two numbers"
echo "Enter 2 to exit"

read choice

if [ "$choice" == "1" ]
then
echo  "Give me number 1"
read num1
echo "Give me number 2"
read num2
echo "The sum is $(($num1+$num2))"
elif [ "$choice" == "2" ]
then
	repeat="false"
else
echo "Please enter a correct option"
fi
done
