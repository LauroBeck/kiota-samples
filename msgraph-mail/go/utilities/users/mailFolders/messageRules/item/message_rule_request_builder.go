package item
import (
    "github.com/microsoft/kiota-samples/msgraph-mail/go/utilities/users"
    "github.com/microsoft/kiota/abstractions/go/serialization"
    "github.com/microsoft/kiota/abstractions/go"
)
type MessageRuleRequestBuilder struct {
    currentPath *string;
    httpCore HttpCore;
    pathSegment *string;
}
