# TelerikMemoryLeakTest
Memory Leak test for Telerik Controls

 
# Notes: -

	After running from the IDE you need to then run the application without the debugger attached otherwise there are still memory leaks.
	
    I’m not attempting any cleanup of the backing store collection used in the standard list view.  It just works for the standard view and clean’s up if 10 items.  Maybe there is a subtle difference and it needs something extra for Telerik - that would be fine if it no longer leaks. At the moment I have modified the TestListViewItemTemplate_Tapped event in the TelerikListViewTestView.Xaml.cs file to clear the collection and dataGrid Items Source but this does not seem to help…
	
    Memory leaks are detected using MemoryTrackingService.  This seems to work well for us in identifying leaks and fixing them.  

NB. Running the same tests do NOT leak on Android….

# ListView Test:
	Tap on 'Show ListView Test' button with 10 Items configured —> 'ListView Test' page is shown, tap on any item a couple of times to reload the ListView collection (Simulating Expand/Collapse toggling, it reloads full collection or only even numbered items) —> Tap on ‘Back’ button to return to Main Page, then tap on ‘Show Memory Usage’ button to see results. ‘ListViewTestView’ and ‘ListViewTestViewModel’ do not leak memory. 
	
    Tap on 'Show ListView Test' button with 50 Items configured —> 'ListView Test' page is shown, tap on any item a couple of times to reload the ListView collection —> ‘ListViewTestView’ and ‘ListViewTestViewModel’ leak memory on iOS.

# Telerik ListView Test: (How it should work … but does not)
	Tap on 'Show Telerik ListView Test' button with 10 Items configured —> ‘Telerik ListView Test' page is shown, before - tried to tap on any item a couple of times to reload the ListView collection (Simulating Expand/Collapse toggling, and it would reload the full collection or only even numbered items) —> Tap on ‘Back’ button to return to Main Page, then tap on ‘Show Memory Usage’ button to see results. ‘TelerikListViewTestView’ and ‘TelerikListViewTestViewModel’ were still leaking memory. Now tried just clearing collection but memory still leaks.
	





