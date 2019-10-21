using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using NUnit.Framework;
using UnityEngine.TestTools;

public class SimpleTest
{
    [Test]
    public void SimpleUnityTest()
    {
        Assert.IsTrue(false);
    }

    [UnityTest]
    public IEnumerator SimpleUnityTestTools()
    {
        yield return new WaitForFixedUpdate();

        Assert.IsTrue(false, "Unity Test Failed");
    }
}
