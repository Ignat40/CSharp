namespace ExamPrep;


/*

    MVVM PATTERN: Simplifies UI Updates and Improves code modularity, reusability and testing. 

        Model -> represents the data and business logic layer 
        View -> Defines the UI. They contain data bindings to the ViewModel, controls and definition.
        ViewModel -> Middleman between M and V. Connects the Model with the View, handling logic.
        It hold presentation logic and state, responding to commands and hadling data manipulation.
        Ofter inferit ReactiveObjects

        Avalonia UI: (uses the .axaml files)

        • ReactiveUI allows ViewModel properties to automatically 
          notify the View of changes, and for UI events
          to be bound to ViewModel commands.

        • ReactiveObjects -> infrastructure for property change notifications.
        • RaiseAndSetIfChanged -> handles property changes, rising notificatins 
        only when values actually change.

        • ObservableCollection -> notifies the View of any changes to it
          
        • ReactiveCommand -> command triggered by the UI, bind with button
        • {Binding var Name} -> we are looking for a data context with this property name
        • BindingMode -> specifies the direction of data binding
        • INotifyPropertyChanged -> Allows objects to notify subscribers about chagnes to their properites 
        • 

        

        


*/


public class AvaloniaUI
{

}