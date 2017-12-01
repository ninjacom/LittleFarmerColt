//
// Reaktion - An audio reactive animation toolkit for Unity.
//
// Copyright (C) 2013, 2014 Keijiro Takahashi
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of
// this software and associated documentation files (the "Software"), to deal in
// the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do so,
// subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
// FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
// COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
// IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
// CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
using UnityEngine;
using System.Collections;

namespace Reaktion {

[AddComponentMenu("Reaktion/Gear/Light Gear")]
public class LightGear : MonoBehaviour
{
    public ReaktorLink reaktor;
    public Modifier intensity;
    public bool enableColor;
    public Gradient colorGradient;
    public bool enableBeatAccumulatedColor;
    public float accumulatedColorRate;

    void Awake()
    {
        reaktor.Initialize(this);
        UpdateLight(0,0);
    }

    void Update()
    {
      UpdateLight(reaktor.Output, (reaktor.OutputAccumulated * accumulatedColorRate) % 1.0f);
    }

    void UpdateLight(float param, float param2)
    {
        if (intensity.enabled)
            GetComponent<Light>().intensity = intensity.Evaluate(param);
        if (enableColor)
            GetComponent<Light>().color = colorGradient.Evaluate(param);
        if (enableBeatAccumulatedColor) {
            GetComponent<Light>().color = colorGradient.Evaluate(param2);
        }
    }
}

} // namespace Reaktion
