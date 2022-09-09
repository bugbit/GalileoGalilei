using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This file contains summary information on all major solar system bodies. It includes all planets, dwarf planets and moons, but does not include asteroids or comets; these are contained in another dataset.
/// </summary>
//[CreateAssetMenu(fileName="New Solar data", menuName="Assets/NewSolData")]
public class SolDataItem : MonoBehaviour
{
    // eName - string - the name of the object
    public string eName;
    // isPlanet - boolean - is the object a planet (this includes the five dwarf planets)
    public Boolean isPlanet;
    // semimajorAxis - integer - mean orbital distance in km
    public decimal semimajorAxis;
    // perihelion - integer - closest distance from the Sun during its orbit
    public decimal perihelion;
    // aphelion - integer - furthest distance from the Sun during its orbit
    public decimal aphelion;
    // eccentricity - double - ratio of perihelion to aphelion
    public double eccentricity;
    // inclination - double - difference in angle between body's orbit and the ecliptic
    public double inclination;
    // density - double - average density of the body
    public double density;
    // gravity - double - surface gravity, measures in m/s^2
    public double gravity;
    // escape - integer - escape velocity at surface level
    public double escape;
    // meanRadius - double - average total radius
    public double meanRadius;
    // equaRadius - double - average equatorial radius
    public double equaRadius;
    // polarRadius - double - average polar radius
    public double polarRadius;
    // flattening - double - ratio of equatorial radius to polar radius
    public double flattening;
    // dimension - string - approximate spatial dimensions of irregular shaped objects
    public string dimension;
    // sideralOrbit - double - orbital period in Earth days
    public double sideralOrbit;
    // sideralRotation - double - rotational period in hours
    public double sideralRotation;
    // discoveryDate - date - date of discovery, this is left blank for any objects that were known since antiquity
    public string discoveryDate;
    // mass_kg - integer - total estimated mass of object in kg
    public double mass_kg;
    // volume - integer - approximate volume in km^3
    public string volume;
    // orbit_type - class - either primary; orbites the Sun, or secondary; orbits a planet
    public string orbit_type;
    // orbits - class - the planet that the body orbits. If it does not orbit a planet then it is NA
    public string orbits;
    // bondAlbido - double - Bond albedo, portion of light/energy that get reflected by the surface
    public string bondAlbido;
    // geomAlbido - double - Geometric albedo, modified reflective metric for spherical objects which, because of opposition effects, can be greater than 1
    public string geomAlbido;
    // RV_abs - double - radial velocity of Sun due to object's gravitational pull
    public string RV_abs;
    // p_transit - double - probability that a transit will be observable
    public string p_transit;
    // transit_visibility - double - angle from the ecliptic that a transit will be visible
    public string transit_visibility;
    // transit_depth - double - portion of Sun's energy that is blocked during transit
    public double transit_depth;
    // massj - integer - mass compared to Jupiter
    public double massj;
    // semimajorAxis_AU - integer - orbital radius in Astronomical Units
    public double semimajorAxis_AU;
    // grav_int - gravitational interaction with the Sun
    public string grav_int;
}
