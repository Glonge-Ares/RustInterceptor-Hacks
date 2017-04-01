using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Box {
    class MyApplicationContext: ApplicationContext {

        public static List<Form> forms = new List<Form>() {
        new Overlay(),
        new GUI(),
        };

    private void OnFormClosed(object sender, EventArgs e) {
            if (Application.OpenForms.Count == 0) {
                ExitThread();
            }
        }

        public MyApplicationContext() {
            //If WinForms exposed a global event that fires whenever a new Form is created,
            //we could use that event to register for the form's `FormClosed` event.
            //Without such a global event, we have to register each Form when it is created
            //This means that any forms created outside of the ApplicationContext will not prevent the 
            //application close.

            foreach (var form in forms) {
                form.FormClosed += OnFormClosed;
            }

            //to show all the forms on start
            //can be included in the previous foreach
            foreach (var form in forms) {
                form.Show();
            }

            //to show only the first form on start
            //forms[1].Show();
        }
    }
}