﻿/*
 * Copyright(c) 2025 Samsung Electronics Co., Ltd.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */
using System;
using Tizen.NUI;
using Tizen.NUI.BaseComponents;
using Tizen.NUI.Components;

namespace NUILayout
{
    internal class AbsolutePosPMarginMargin : View, IExample
    {
        public AbsolutePosPMarginMargin()
        {
            Layout = new AbsoluteLayout();
            WidthSpecification = LayoutParamPolicies.MatchParent;
            HeightSpecification = LayoutParamPolicies.MatchParent;
            BackgroundColor = Color.Gray;

            var absoluteLayout = new View()
            {
                Layout = new AbsoluteLayout(),
                WidthSpecification = LayoutParamPolicies.MatchParent,
                HeightSpecification = LayoutParamPolicies.MatchParent,
                BackgroundColor = Color.DarkGray,
                Margin = 100,
            };
            Add(absoluteLayout);

            var origin = new View()
            {
                Layout = new AbsoluteLayout(),
                WidthSpecification = 100,
                HeightSpecification = 100,
                BackgroundColor = Color.LightBlue,
                Margin = 100,
            };
            absoluteLayout.Add(origin);

            var view = new View()
            {
                Layout = new AbsoluteLayout(),
                WidthSpecification = 100,
                HeightSpecification = 100,
                Position = new Position(100, 100),
                BackgroundColor = Color.Blue,
                Margin = 100,
            };
            absoluteLayout.Add(view);

            var timer = new Tizen.NUI.Timer(1000);
            timer.Tick += (o, e) =>
            {
                view.Layout.RequestLayout(); // Test if AbsoluteLayout position is updated unexpectedly.
                return true;
            };
            timer.Start();
        }

        public void Activate()
        {
            Console.WriteLine($"@@@ this.GetType().Name={this.GetType().Name}, Activate()");

            var contentPage = new ContentPage()
            {
                AppBar = new AppBar() { Title = "Position ParentMargin Margin", BackgroundColor = Color.White },
                Content = this,
                WidthSpecification = LayoutParamPolicies.MatchParent,
                HeightSpecification = LayoutParamPolicies.MatchParent,
                BackgroundColor = Color.LightGray,
            };
            Window.Default.GetDefaultNavigator().Push(contentPage);
        }
        public void Deactivate()
        {
            Console.WriteLine($"@@@ this.GetType().Name={this.GetType().Name}, Deactivate()");
            Window.Default.GetDefaultNavigator().Pop();
        }
    }
}
