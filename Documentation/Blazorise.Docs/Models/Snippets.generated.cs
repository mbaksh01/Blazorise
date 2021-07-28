//-----------------------------------------------------------------------
// This file is autogenerated by Blazorise.Docs.Compiler
// Any changes to this file will be overwritten on build
// <auto-generated />
//-----------------------------------------------------------------------

namespace Blazorise.Docs.Models
{
    public static partial class Snippets
    {
        public const string ButtonAddonExample = @"<Addons>
    <Addon AddonType=""AddonType.Body"">
        <TextEdit Placeholder=""Recipient's username"" />
    </Addon>
    <Addon AddonType=""AddonType.End"">
        <Button Color=""Color.Secondary"">Button</Button>
    </Addon>
</Addons>";

        public const string DropdownAddonExample = @"<Addons>
    <Addon AddonType=""AddonType.Start"">
        <Dropdown>
            <DropdownToggle Color=""Color.Primary"">Dropdown</DropdownToggle>
            <DropdownMenu>
                <DropdownItem>Action</DropdownItem>
                <DropdownItem>Another action</DropdownItem>
                <DropdownItem>Something else here</DropdownItem>
                <DropdownDivider />
                <DropdownItem>Separated link</DropdownItem>
            </DropdownMenu>
        </Dropdown>
    </Addon>
    <Addon AddonType=""AddonType.Body"">
        <TextEdit />
    </Addon>
</Addons>";

        public const string MultipleAddonsExample = @"<Addons>
    <Addon AddonType=""AddonType.Start"">
        <AddonLabel>Start</AddonLabel>
    </Addon>
    <Addon AddonType=""AddonType.Body"">
        <TextEdit Placeholder=""Placeholder"" />
    </Addon>
    <Addon AddonType=""AddonType.End"">
        <AddonLabel>End</AddonLabel>
    </Addon>
</Addons>";

        public const string StaticAddonExample = @"<Addons>
    <Addon AddonType=""AddonType.Start"">
        <AddonLabel>@@</AddonLabel>
    </Addon>
    <Addon AddonType=""AddonType.Body"">
        <TextEdit Placeholder=""Username"" />
    </Addon>
</Addons>";

        public const string ActiveButtonExample = @"<Button Color=""Color.Primary"" Active>Primary</Button>
<Button Color=""Color.Secondary"" Active>Secondary</Button>";

        public const string BlockButtonExample = @"<Button Color=""Color.Primary"" Block>Blocked primary</Button>
<Button Color=""Color.Secondary"" Block>Blocked secondary</Button>";

        public const string ButtonExample = @"<Button Color=""Color.Primary"">Click me</Button>";

        public const string ButtonGroupExample = @"<Buttons>
    <Button Color=""Color.Secondary"">LEFT</Button>
    <Button Color=""Color.Secondary"">CENTER</Button>
    <Button Color=""Color.Secondary"">RIGHT</Button>
</Buttons>";

        public const string ButtonUsageExample = @"<Button Color=""Color.Primary"" Clicked=""@OnButtonClicked"">Click me</Button>
@code{
    [Inject] INotificationService NotificationService { get; set; }

    Task OnButtonClicked()
    {
        return NotificationService.Info( ""Hello world!"" );
    }
}";

        public const string ColorButtonsExample = @"<Button Color=""Color.Primary"">Primary</Button>
<Button Color=""Color.Secondary"">Secondary</Button>
<Button Color=""Color.Success"">Success</Button>
<Button Color=""Color.Warning"">Warning</Button>
<Button Color=""Color.Danger"">Danger</Button>
<Button Color=""Color.Info"">Info</Button>
<Button Color=""Color.Light"">Light</Button>
<Button Color=""Color.Dark"">Dark</Button>
<Button>None</Button>";

        public const string DisabledButtonExample = @"<Button Color=""Color.Primary"" Disabled>Primary</Button>
<Button Color=""Color.Secondary"" Disabled>Secondary</Button>";

        public const string LinkButtonExample = @"<Button Color=""Color.Primary"" Type=""ButtonType.Link"" To=""#"">Primary link</Button>
<Button Color=""Color.Secondary"" Type=""ButtonType.Link"" To=""#"" Target=""Target.Blank"">Secondary link</Button>";

        public const string LoadingButtonExample = @"<Button Color=""Color.Primary"" Loading>Primary</Button>
<Button Color=""Color.Primary"" Clicked=""@ShowLoading"" Loading=""@isLoading"">
    <LoadingTemplate>
        This is a custom loading template
    </LoadingTemplate>
    <ChildContent>
        Click to load
    </ChildContent>
</Button>
@code{
    private bool isLoading;

    private async Task ShowLoading()
    {
        isLoading = true;

        await Task.Delay( TimeSpan.FromSeconds( 3 ) );

        isLoading = false;
    }
}";

        public const string OutlineButtonExample = @"<Button Color=""Color.Primary"" Outline>Primary</Button>
<Button Color=""Color.Secondary"" Outline>Secondary</Button>
<Button Color=""Color.Success"" Outline>Success</Button>
<Button Color=""Color.Warning"" Outline>Warning</Button>
<Button Color=""Color.Danger"" Outline>Danger</Button>
<Button Color=""Color.Info"" Outline>Info</Button>
<Button Color=""Color.Light"" Outline>Light</Button>
<Button Color=""Color.Dark"" Outline>Dark</Button>
<Button Outline>None</Button>";

        public const string SubmitButtonExample = @"<Form>
    <Field Horizontal>
        <FieldLabel ColumnSize=""ColumnSize.Is2"">Name</FieldLabel>
        <FieldBody ColumnSize=""ColumnSize.Is10"">
            <TextEdit Placeholder=""Some text value..."" />
        </FieldBody>
    </Field>
    <Field>
        <Button Color=""Color.Primary"" Type=""ButtonType.Submit"" PreventDefaultOnSubmit=""true"">Submit</Button>
    </Field>
</Form>";

        public const string ToolbarButtonsExample = @"<Buttons Role=""ButtonsRole.Toolbar"">
    <Buttons Margin=""Margin.Is2.FromRight"">
        <Button Color=""Color.Primary"">Primary</Button>
        <Button Color=""Color.Secondary"">Secondary</Button>
        <Button Color=""Color.Info"">Info</Button>
    </Buttons>
    <Buttons>
        <Button Color=""Color.Danger"">Danger</Button>
        <Button Color=""Color.Warning"">Warning</Button>
    </Buttons>
    <Buttons Margin=""Margin.Is2.OnX"">
        <Button Color=""Color.Success"">Success</Button>
    </Buttons>
</Buttons>";

        public const string CardDeckExample = @"<CardDeck>
    <Card>
        <CardImage Source=""/img/gallery/2.jpg"" Alt=""Card image cap 3""></CardImage>
        <CardBody>
            <CardTitle Size=""5"">Card title 1</CardTitle>
            <CardText>
                This is a longer card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.
            </CardText>
            <Button Color=""Color.Primary"">Button</Button>
        </CardBody>
    </Card>
    <Card>
        <CardImage Source=""/img/gallery/3.jpg"" Alt=""Card image cap 9""></CardImage>
        <CardBody>
            <CardTitle Size=""5"">Card title 2</CardTitle>
            <CardText>
                This card has supporting text below as a natural lead-in to additional content.
            </CardText>
            <Button Color=""Color.Primary"">Button</Button>
        </CardBody>
    </Card>
    <Card>
        <CardImage Source=""/img/gallery/4.jpg"" Alt=""Card image cap 12""></CardImage>
        <CardBody>
            <CardTitle Size=""5"">Card title 3</CardTitle>
            <CardText>
                This is a wider card with supporting text below as a natural lead-in to additional content. This card has even longer content than the first to show that equal height action.
            </CardText>
            <Button Color=""Color.Primary"">Button</Button>
        </CardBody>
    </Card>
</CardDeck>";

        public const string CardExample = @"<Card Margin=""Margin.Is4.OnY"">
    <CardImage Source=""img/gallery/7.jpg"" Alt=""Placeholder image"">
    </CardImage>
    <CardBody>
        <CardTitle Size=""5"">Card title</CardTitle>
        <CardText>
            Some quick example text to build on the card title and make up the bulk of the card's content.
        </CardText>
        <Button Color=""Color.Primary"">Button</Button>
    </CardBody>
</Card>";

        public const string CheckExample = @"<Check TValue=""bool"">Check me out</Check>";

        public const string CheckWithBindExample = @"<Check TValue=""bool"" @bind-Checked=""@rememberMe"">Remember Me</Check>

@code{
    bool rememberMe;
}";

        public const string CheckWithEventExample = @"<Check TValue=""bool"" Checked=""@rememberMe"" CheckedChanged=""@OnRememberMeChanged"">Remember Me</Check>

@code{
    bool rememberMe;

    void OnRememberMeChanged( bool value )
    {
        rememberMe = value;
    }
}";

        public const string BasicColorExample = @"<ColorEdit Color=""#ff0000"" />";

        public const string BasicDateEditExample = @"<DateEdit TValue=""DateTime?"" />";

        public const string BasicDatePickerExample = @"<DatePicker TValue=""DateTime?"" />";

        public const string DateEditDateTimeExample = @"<DateEdit TValue=""DateTime?"" InputMode=""DateInputMode.DateTime"" />";

        public const string DateEditWithBindExample = @"<DateEdit TValue=""DateTime?"" @bind-Date=""@selectedDate"" />

@code{
    DateTime? selectedDate;
}";

        public const string DateEditWithEventExample = @"<DateEdit TValue=""DateTime?"" Date=""@selectedDate"" DateChanged=""@OnDateChanged"" />

@code{
    DateTime? selectedDate;

    void OnDateChanged( DateTime? date )
    {
        selectedDate = date;
    }
}";

        public const string DatePickerWithIconExample = @"<Addons>
    <Addon AddonType=""AddonType.Body"">
        <DatePicker @ref=""@datePicker"" TValue=""DateTime?"" />
    </Addon>
    <Addon AddonType=""AddonType.End"">
        <Button Color=""Color.Light"" Clicked=""@(()=>datePicker.ToggleAsync())"">
            <Icon Name=""IconName.CalendarDay"" />
        </Button>
    </Addon>
</Addons>
@code{
    DatePicker<DateTime?> datePicker;
}";

        public const string DashedDividerExample = @"<Divider DividerType=""DividerType.Dashed"" />";

        public const string DottedDividerExample = @"<Divider DividerType=""DividerType.Dotted"" />";

        public const string SolidDividerExample = @"<Divider />";

        public const string TextContentDividerExample = @"<Divider DividerType=""DividerType.TextContent"" Text=""Hello Blazorise"" />";

        public const string BasicFieldExample = @"<Field>
    <TextEdit Placeholder=""Name"" />
</Field>";

        public const string BasicFieldsExample = @"<Fields>
    <Field ColumnSize=""ColumnSize.Is6.OnDesktop"">
        <FieldLabel>City</FieldLabel>
        <TextEdit />
    </Field>
    <Field ColumnSize=""ColumnSize.Is4.OnDesktop"">
        <FieldLabel>State</FieldLabel>
        <Select TValue=""string"">
        </Select>
    </Field>
    <Field ColumnSize=""ColumnSize.Is2.OnDesktop"">
        <FieldLabel>Zip</FieldLabel>
        <TextEdit />
    </Field>
</Fields>";

        public const string FieldHiddenExample = @"<Field Visibility=""Visibility.Invisible"">
    <TextEdit />
</Field>";

        public const string FieldWithHelpExample = @"<Field>
    <FieldLabel>Email address</FieldLabel>
    <TextEdit Placeholder=""Enter email"">
        <FieldHelp>Please enter a valid email address</FieldHelp>
    </TextEdit>
</Field>";

        public const string FieldWithLabelExample = @"<Field>
    <FieldLabel>Email address</FieldLabel>
    <TextEdit Placeholder=""Enter email"" />
</Field>";

        public const string HorizontalFieldExample = @"<Field Horizontal=""true"">
    <FieldLabel ColumnSize=""ColumnSize.Is2"">Name</FieldLabel>
    <FieldBody ColumnSize=""ColumnSize.Is10"">
        <TextEdit Placeholder=""Some text value..."" />
    </FieldBody>
</Field>";

        public const string ExtensionsLimitFileEditExample = @"<!-- Accept all image formats by IANA media type wildcard-->
<FileEdit Filter=""image/*"" />

<!-- Accept specific image formats by IANA type -->
<FileEdit Filter=""image/jpeg, image/png, image/gif"" />

<!-- Accept specific image formats by extension -->
<FileEdit Filter="".jpg, .png, .gif"" />";

        public const string MultipleFileEditExample = @"<FileEdit Changed=""@OnChanged"" Multiple=""true"" />
@code{
    Task OnChanged( FileChangedEventArgs e )
    {
        return Task.CompletedTask;
    }
}";

        public const string OpenReadStreamFileEditExample = @"@using System.IO

<FileEdit Changed=""@OnChanged"" Written=""@OnWritten"" Progressed=""@OnProgressed"" />

@code{
    string fileContent;

    const int OneMb = 1024 * 1024;

    async Task OnChanged( FileChangedEventArgs e )
    {
        try
        {
            var file = e.Files.FirstOrDefault();
            if ( file == null )
            {
                return;
            }

            var buffer = new byte[OneMb];
            using ( var bufferedStream = new BufferedStream( file.OpenReadStream( long.MaxValue ), OneMb ) )
            {
                int readCount = 0;
                int readBytes;
                while ( ( readBytes = await bufferedStream.ReadAsync( buffer, 0, OneMb ) ) > 0 )
                {
                    Console.WriteLine( $""Read:{readCount++} {readBytes / (double)OneMb} MB"" );
                    // Do work on the first 1MB of data
                }
            }
        }
        catch ( Exception exc )
        {
            Console.WriteLine( exc.Message );
        }
        finally
        {
            this.StateHasChanged();
        }
    }

    void OnWritten( FileWrittenEventArgs e )
    {
        Console.WriteLine( $""File: {e.File.Name} Position: {e.Position} Data: {Convert.ToBase64String( e.Data )}"" );
    }

    void OnProgressed( FileProgressedEventArgs e )
    {
        Console.WriteLine( $""File: {e.File.Name} Progress: {e.Percentage}"" );
    }
}";

        public const string ResetFileEditExample = @"<FileEdit @ref=""@fileEdit"" AutoReset=""false"" Changed=""@OnChanged"" />
@code{
    FileEdit fileEdit;

    Task OnChanged( FileChangedEventArgs e )
    {
        return Task.CompletedTask;
    }

    Task OnSomeButtonClick()
    {
        return fileEdit.Reset().AsTask();
    }
}";

        public const string SingleFileEditExample = @"<FileEdit Changed=""@OnChanged"" />
@code{
    Task OnChanged( FileChangedEventArgs e )
    {
        return Task.CompletedTask;
    }
}";

        public const string WriteToStreamFileEditExample = @"@using System.IO

<FileEdit Changed=""@OnChanged"" Written=""@OnWritten"" Progressed=""@OnProgressed"" />

@code{
    string fileContent;

    async Task OnChanged( FileChangedEventArgs e )
    {
        try
        {
            foreach ( var file in e.Files )
            {
                // A stream is going to be the destination stream we're writing to.
                using ( var stream = new MemoryStream() )
                {
                    // Here we're telling the FileEdit where to write the upload result
                    await file.WriteToStreamAsync( stream );

                    // Once we reach this line it means the file is fully uploaded.
                    // In this case we're going to offset to the beginning of file
                    // so we can read it.
                    stream.Seek( 0, SeekOrigin.Begin );

                    // Use the stream reader to read the content of uploaded file,
                    // in this case we can assume it is a textual file.
                    using ( var reader = new StreamReader( stream ) )
                    {
                        fileContent = await reader.ReadToEndAsync();
                    }
                }
            }
        }
        catch ( Exception exc )
        {
            Console.WriteLine( exc.Message );
        }
        finally
        {
            this.StateHasChanged();
        }
    }

    void OnWritten( FileWrittenEventArgs e )
    {
        Console.WriteLine( $""File: {e.File.Name} Position: {e.Position} Data: {Convert.ToBase64String( e.Data )}"" );
    }

    void OnProgressed( FileProgressedEventArgs e )
    {
        Console.WriteLine( $""File: {e.File.Name} Progress: {e.Percentage}"" );
    }
}";

        public const string AnchorLinkExample = @"<Link To=""#"">
    Link
</Link>";

        public const string BasicLinkExample = @"<Link To=""docs"">
    Link
</Link>";

        public const string BasicMemoEditExample = @"<MemoEdit Rows=""5"" />";

        public const string MemoEditTextChangedModeExample = @"public void ConfigureServices( IServiceCollection services )
{
  services
    .AddBlazorise( options =>
    {
      options.ChangeTextOnKeyPress = false;
    } );
}";

        public const string MemoEditTextDelayModeExample = @"public void ConfigureServices( IServiceCollection services )
{
  services
    .AddBlazorise( options =>
    {
      options.DelayTextOnKeyPress = true;
      options.DelayTextOnKeyPressInterval = 300;
    } );
}";

        public const string MemoEditWithBindExample = @"<MemoEdit @bind-Text=""@description"" />

@code{
    string description;
}";

        public const string MemoEditWithEventExample = @"<MemoEdit Text=""@description"" TextChanged=""@OnDescriptionChanged"" />

@code{
    string description;

    Task OnDescriptionChanged( string value )
    {
        description = value;

        return Task.CompletedTask;
    }
}";

        public const string BasicNumericEditExample = @"<NumericEdit Value=""123"" />";

        public const string NumericEditGenericExample = @"<NumericEdit TValue=""decimal?"" />";

    }
}
