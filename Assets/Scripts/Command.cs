/*
 1. IDENTIFYING INFORMATION
a. Devin Keller, Kentaro Matsui, Tad Kitagushi, Miles Rovenger
b. Student ID: 2368610, 2366951, 2403661, 2343785
c. dkeller@chapman.edu, matsuo@chapman.edu, tkitaguchi@chapman.edu, rovenger@chapman.edu
d. CPSC-245
e. Final Project: PacMan
*/

/*
 * This class will have a triggerable command using an “Execute” method. 
 *  The virtual keyword will need to be used so methods can be overridden.
 *
 * Classes that need to extend from the base “Command.cs” class.
    a. “Move”. Will move the character object right or left 1 unit on the X-axis when it is pressed.
 */

using UnityEngine;

/*
 * Classes that extend from base class
 * - Move
 */
public abstract class Command
{
    public virtual void Execute(GameObject gameObject)
    {
        // Base implementation
    }
}