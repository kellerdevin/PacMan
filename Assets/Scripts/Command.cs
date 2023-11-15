/**
 * a. Devin Keller
b. Student ID: 2368610
c. dkeller@chapman.edu
d. CPSC-245
e. Assignment 1
 */

/*
 * This class will have a triggerable command using an “Execute” method. 
 *  The virtual keyword will need to be used so methods can be overridden.
 *
 * Classes that need to extend from the base “Command.cs” class.
    a. “Move”. Will move the character object right or left 1 unit on the X-axis when it is pressed.
 */
using System.Collections;
using System.Collections.Generic;
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