#include <iostream>

int main()
{
	double s, k, c, k1, k2, dk, x;

	std::cout << "Enter the initial K value :";
	std::cin >> k1;

	std::cout << "Enter the end K value :";
	std::cin >> k2;

	std::cout << "Enter the change step :";
	std::cin >> dk;

	std::cout << "Enter the price :";
	std::cin >> c;

	for (k = k1; k <= k2; k += dk)
	{
		s = k * c;
		std::cout << "k = " << k << "s = " << s << std::endl;
	}

	return 0;
}