# Signing Free Agent Players
Signing free Agent Baseball Players is a problem from text book titled [Introduction to Algorithm](https://mitpress.mit.edu/books/introduction-algorithms-third-edition) written by Thomas H. Cormen, Charles E. Lieserson, Ronald L. Rivest, Clifford Stein.
# Problem
Suppose that you are the general manager for a major-league baseball team. During the off-season, you need to sign some free-agent players for your team. The team owner has given you a budget of **$X** to spend on free agents. You are allowed to spend less than **$X** altogether, but the owner will fire you if you spend any more than **$X**.
You are considering $N$ different positions, and for each position, **P** free-agent players who play that position are available. Because you do not want to overload your roster with too many players at any position, for each position you may sign at most one free agent who plays that position. (If you do not sign any players at a particular position, then you plan to stick with the players you already have at that position.)
To determine how valuable a player is going to be, you decide to use a sabermetric statistic known as ''**VORP**'', or ''**value over replacement player**''. A player with a higher **VORP** is more valuable than a player with a lower **VORP**. A player with a higher **VORP** is not necessarily more expensive to sign than a player with a lower **VORP**, because factors other than a player's value determine how much it costs to sign him. 
For each available free-agent player, you have three pieces of information:
 - the player's position,
 - the amount of money it will cost to sign the player, and
 - the player's VORP.
 
Devise an algorithm that maximizes the total **VORP** of the players you sign while spending no more than $\$X$ altogether. You may assume that each player signs for a multiple of $100,000$. Your algorithm should output the total **VORP** of the players you sign, the total amount of money you spend, and a list of which players you sign. Analyze the running time and space requirement of your algorithm.

# Solution:
Let  ***$L = {p1, p2, ... , pk}*** be a set of players, possibly empty, with maximum **VORP** for the subproblem **(i, x)**.

1. If i = N, then L has at most one player. If all players in position $N$ have cost more than x, then L has no players. Otherwise, L = p1, where p1 has the maximum VORP among players for position N with cost at most x.
2. If i < N and L includes player p for position i, then L' = L - {p} is an optimal set for the subproblem (i + 1, x - p.cost).
3. If i < N and L does not include a player for position i, then L is an optimal set for the subproblem i + 1, x.

# How To run code:
This proogram is written on c# language as a windows console application. 
You Need  Visual Studio IDE and .Net framework 4.x+ to run the program.
Fork the project and run .sln file in SigningFreeAgentPlayers directory to open project as Visual studio project.

# Citation:
- [Solution of Introduction to algorithm by Walkccc]

# Team Members:
- [Rameez ul Haq ansari](https://github.com/iamramizansari) (15b-062-se)
- Shanza Khan (15b-042-se)
- [M Rayyan](https://github.com/iamrayyan) (15b-037-se)

# Licensing

All the file in this repository are released under the [Creative Commons Attribution-ShareAlike 3.0 Unported license](http://creativecommons.org/licenses/by-sa/3.0/).
For attribution, any software using source code from this repository must include a clear mention of the this project and a link to [github/iamramiznansari](http://github.com/iamramizansari/). 


[Solution of Introduction to algorithm by Walkccc]: <https://walkccc.github.io/CLRS/>


