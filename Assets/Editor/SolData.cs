using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="New Solar data", menuName="Assets/NewSolData")]
public class SolData : ScriptableObject
{
    // eName - string - the name of the object
    String eName;
    // isPlanet - boolean - is the object a planet (this includes the five dwarf planets)
    String isPlanet;
    // semimajorAxis - integer - mean orbital distance in km
    decimal semimajorAxis;
    // perihelion - integer - closest distance from the Sun during its orbit
    decimal perihelion;
    // aphelion - integer - furthest distance from the Sun during its orbit
    decimal aphelion;
    // eccentricity - double - ratio of perihelion to aphelion
    double eccentricity;
    // inclination - double - difference in angle between body's orbit and the ecliptic
    double inclination;
    // density - double - average density of the body
    double density;
    // gravity - double - surface gravity, measures in m/s^2
    double gravity;
    // escape - integer - escape velocity at surface level
    double escape;
    // meanRadius - double - average total radius
    double meanRadius;
    // equaRadius - double - average equatorial radius
    double equaRadius;
    // polarRadius - double - average polar radius
    double polarRadius;
    // flattening - double - ratio of equatorial radius to polar radius
    double flattening;
    // dimension - string - approximate spatial dimensions of irregular shaped objects
    String dimension;
    // sideralOrbit - double - orbital period in Earth days
    double sideralOrbit;
    // sideralRotation - double - rotational period in hours
    double sideralRotation;
    // discoveryDate - date - date of discovery, this is left blank for any objects that were known since antiquity
    String discoveryDate;
    // mass_kg - integer - total estimated mass of object in kg
    double mass_kg;
    // volume - integer - approximate volume in km^3
    String volume;
    // orbit_type - class - either primary; orbites the Sun, or secondary; orbits a planet
    String orbit_type;
    // orbits - class - the planet that the body orbits. If it does not orbit a planet then it is NA
    String orbits;
    // bondAlbido - double - Bond albedo, portion of light/energy that get reflected by the surface
    String bondAlbido;
    // geomAlbido - double - Geometric albedo, modified reflective metric for spherical objects which, because of opposition effects, can be greater than 1
    String geomAlbido;
    // RV_abs - double - radial velocity of Sun due to object's gravitational pull
    String RV_abs;
    // p_transit - double - probability that a transit will be observable
    String p_transit;
    // transit_visibility - double - angle from the ecliptic that a transit will be visible
    String transit_visibility;
    // transit_depth - double - portion of Sun's energy that is blocked during transit
    double transit_depth;
    // massj - integer - mass compared to Jupiter
    double massj;
    // semimajorAxis_AU - integer - orbital radius in Astronomical Units
    double semimajorAxis_AU;
    // grav_int - gravitational interaction with the Sun
    String grav_int;
}
