repeat="true"
sum=0

while [ "$repeat" == "true" ]
do
	echo "Welcome to The Piggly Wiggly Market"
	echo "Enter 1 to enter list"
	echo "Enter 2 to exit"
	read answer

if [ "$answer" == "1" ]
then
	while [ "$repeat" == "true" ]
	do
	echo "Please choose an option"
	echo "1. Bread"
	echo "2. Cheese"
	echo "3. Milk"
	echo "4. Sugar"
	echo "5. Salt"
	echo "6. Checkout"
	read choice
	if [ "$choice" == "1" ]
	then
		echo "Bread: 2"
		sum=$(($sum+2))

	elif [ "$choice" == "2" ]
	then
		echo "Cheese: 3"
		sum=$(($sum+3))
	elif [ "$choice" == "3" ]
	then
		echo "Milk: 3"
		sum=$(($sum+3))
	elif [ "$choice" == "4" ]
	then
		echo "Sugar: 2"
		sum=$(($sum+2))
	elif [ "$choice" == "5" ]
	then
		echo "Salt: 2"
		sum=$(($sum+2))
	elif [ "$choice" == "6" ]
	then
	echo "Your total is $ $sum"
	repeat="false"
	else
		echo "Choose valid answer"
	fi
	done

elif [ "$answer" == "2" ]
then
	repeat="false"
else
	echo "Enter correct choice"
fi
done

