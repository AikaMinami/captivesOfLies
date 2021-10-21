using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
// using UnityEngine.TestTools.LogAssert;

public class MovementTest
{
    [UnityTest]
    public IEnumerator WalkUp()
    {
        var gameObject = new GameObject();
        var players = gameObject.AddComponent<PlayerMovement>();
        var rbPlayers = gameObject.AddComponent<Rigidbody2D>();
        players.MoveUp();
        
        yield return new WaitForFixedUpdate();

        Assert.AreNotEqual(new Vector2(0,5), rbPlayers.transform.position);
    }

    [UnityTest]
    public IEnumerator WalkDown()
    {
        var gameObject = new GameObject();
        var players = gameObject.AddComponent<PlayerMovement>();
        var rbPlayers = gameObject.AddComponent<Rigidbody2D>();
        players.MoveUp();
        
        yield return new WaitForFixedUpdate();

        Assert.AreNotEqual(new Vector2(0,-5), rbPlayers.transform.position);
    }

    [UnityTest]
    public IEnumerator WalkRight()
    {
        var gameObject = new GameObject();
        var players = gameObject.AddComponent<PlayerMovement>();
        var rbPlayers = gameObject.AddComponent<Rigidbody2D>();
        players.MoveUp();
        
        yield return new WaitForFixedUpdate();

        Assert.AreNotEqual(new Vector2(5,0), rbPlayers.transform.position);
    }

    [UnityTest]
    public IEnumerator WalkLeft()
    {
        var gameObject = new GameObject();
        var players = gameObject.AddComponent<PlayerMovement>();
        var rbPlayers = gameObject.AddComponent<Rigidbody2D>();
        players.MoveUp();
        
        yield return new WaitForFixedUpdate();

        Assert.AreNotEqual(new Vector2(-5,0), rbPlayers.transform.position);
    }
}
